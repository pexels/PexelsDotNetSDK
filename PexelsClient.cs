using Newtonsoft.Json;
using PexelsDotNetSDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PexelsDotNetSDK.Api
{
    /// <summary>
    /// It is free to sign up and use the Pexels API. 
    /// - Sign Up here: https://www.pexels.com 
    /// - visit https://www.pexels.com/api/new/ to obtain your API key
    /// </summary>
    public class PexelsClient
    {
        private static HttpClient client;

        private static string _token = "";
        private static string _baseAddress = BaseConstants.API_URL;
        private static string _apiVersion = BaseConstants.API_URL_VERSION;
        private static int _timeoutSecs = BaseConstants.REQUEST_TIMEOUT_SECS;

        public PexelsClient(string token)
        {
            _token = token;
            if (client == null)
            {
                this.CreateClient();
            }
            SetupClientAuthHeader(client);
        }

        private HttpClient CreateClient()
        {
            client = new HttpClient();
            SetupClientDefaults(client);
            return client;
        }

        protected virtual void SetupClientDefaults(HttpClient client)
        {
            client.Timeout = TimeSpan.FromSeconds(_timeoutSecs);
            client.BaseAddress = new Uri(_baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected virtual void SetupClientAuthHeader(HttpClient client)
        {
            client.DefaultRequestHeaders.Remove("Authorization");
            client.DefaultRequestHeaders.Add("Authorization", _token);
        }

        /// <summary>
        /// This endpoint enables you to search Pexels for any topic that you would like. For example your query could be something broad like 'Nature', 
        /// 'Tigers', 'People'. Or it could be something specific like 'Group of people working'.
        /// </summary>
        /// <param name="query">The search query. Ocean, Tigers, Pears, etc.</param>
        /// <param name="locale">The locale of the search you are performing. The current supported locales are: 'en-US' 'pt-BR' 'es-ES' 'ca-ES' 'de-DE' 'it-IT' 'fr-FR' 'sv-SE' 'id-ID' 'pl-PL' 'ja-JP' 'zh-TW' 'zh-CN' 'ko-KR' 'th-TH' 'nl-NL' 'hu-HU' 'vi-VN' 'cs-CZ' 'da-DK' 'fi-FI' 'uk-UA' 'el-GR' 'ro-RO' 'nb-NO' 'sk-SK' 'tr-TR' 'ru-RU'.</param>
        /// <param name="page">The number of the page you are requesting. Default: 1</param>
        /// <param name="pageSize">The number of results you are requesting per page. Default: 15 Max: 80</param>
        /// <returns></returns>
        public async Task<PhotoPage> SearchPhotosAsync(string query, string locale = "", int page = 1, int pageSize = 15)
        {
            if (pageSize > 80) pageSize = 80;
            if (pageSize <= 0) pageSize = 1;
            if (page <= 0) page = 1;

            string _requestUrl = $"{_apiVersion}search?query={Uri.EscapeDataString(query)}&page={page}&per_page={pageSize}";
            if (!string.IsNullOrEmpty(locale))
            {
                _requestUrl += $"&locale={locale}";
            }

            HttpResponseMessage response = await client.GetAsync(_requestUrl);

            var output = await ProcessResult<PhotoPage>(response);
            output.rateLimit = ProcessRateLimits(response);

            return output;
        }

        /// <summary>
        /// This endpoint enables you to receive real-time photos curated by the Pexels team.
        /// We add at least one new photo per hour to our curated list so that you always get a changing selection of trending photos.
        /// </summary>
        /// <param name="page">The number of the page you are requesting. Default: 1</param>
        /// <param name="pageSize">The number of results you are requesting per page. Default: 15 Max: 80</param>
        /// <returns></returns>
        public async Task<PhotoPage> CuratedPhotosAsync(int page = 1, int pageSize = 15)
        {
            if (pageSize > 80) pageSize = 80;
            if (pageSize <= 0) pageSize = 1;
            if (page <= 0) page = 1;

            string _requestUrl = $"{_apiVersion}curated?page={page}&per_page={pageSize}";

            HttpResponseMessage response = await client.GetAsync(_requestUrl);

            var output = await ProcessResult<PhotoPage>(response);
            output.rateLimit = ProcessRateLimits(response);

            return output;
        }

        /// <summary>
        /// Retrieve a specific Photo from its id.
        /// </summary>
        /// <param name="id">The id of the photo you are requesting.</param>
        /// <returns></returns>
        public async Task<Photo> GetPhotoAsync(int id)
        {
            string _requestUrl = $"{_apiVersion}photos/{id}";

            HttpResponseMessage response = await client.GetAsync(_requestUrl);

            return await ProcessResult<Photo>(response);
        }

        /// <summary>
        /// This endpoint enables you to search Pexels for any topic that you would like. For example your query could be something broad like 'Nature', 
        /// 'Tigers', 'People'. Or it could be something specific like 'Group of people working'.
        /// </summary>
        /// <param name="query">The search query. Ocean, Tigers, Pears, etc.</param>
        /// <param name="page">The number of the page you are requesting. Default: 1</param>
        /// <param name="pageSize">The number of results you are requesting per page. Default: 15 Max: 80</param>
        /// <param name="minWidth">The minimum width in pixels of the returned videos.</param>
        /// <param name="minHeight">The minimum height in pixels of the returned videos.</param>
        /// <param name="minDurationSecs">The minimum duration in seconds of the returned videos.</param>
        /// <param name="maxDurationSecs">The maximum duration in seconds of the returned videos.</param>
        /// <returns></returns>
        public async Task<VideoPage> SearchVideosAsync(string query, int page = 1, int pageSize = 15,
            int minWidth = 0, int minHeight = 0, int minDurationSecs = 0, int maxDurationSecs = 0)
        {
            if (pageSize > 80) pageSize = 80;
            if (pageSize <= 0) pageSize = 1;
            if (page <= 0) page = 1;

            string _requestUrl = $"videos/search?query={Uri.EscapeDataString(query)}&page={page}&per_page={pageSize}";
            if (minWidth > 0)
            {
                _requestUrl += $"&min_width={minWidth}";
            }
            if (minHeight > 0)
            {
                _requestUrl += $"&min_height={minHeight}";
            }
            if (minDurationSecs > 0)
            {
                _requestUrl += $"&min_duration={minDurationSecs}";
            }
            if (maxDurationSecs > 0)
            {
                _requestUrl += $"&max_duration={maxDurationSecs}";
            }

            HttpResponseMessage response = await client.GetAsync(_requestUrl);

            var output = await ProcessResult<VideoPage>(response);
            output.rateLimit = ProcessRateLimits(response);

            return output;
        }

        /// <summary>
        /// This endpoint enables you to receive the current popular Pexels videos.
        /// </summary>
        /// <param name="page">The number of the page you are requesting. Default: 1</param>
        /// <param name="pageSize">The number of results you are requesting per page. Default: 15 Max: 80</param>
        /// <param name="minWidth">The minimum width in pixels of the returned videos.</param>
        /// <param name="minHeight">The minimum height in pixels of the returned videos.</param>
        /// <param name="minDurationSecs">The minimum duration in seconds of the returned videos.</param>
        /// <param name="maxDurationSecs">The maximum duration in seconds of the returned videos.</param>
        /// <returns></returns>
        public async Task<VideoPage> PopularVideosAsync(int page = 1, int pageSize = 15,
            int minWidth = 0, int minHeight = 0, int minDurationSecs = 0, int maxDurationSecs = 0)
        {
            if (pageSize > 80) pageSize = 80;
            if (pageSize <= 0) pageSize = 1;
            if (page <= 0) page = 1;

            string _requestUrl = $"videos/popular?page={page}&per_page={pageSize}";
            if (minWidth > 0)
            {
                _requestUrl += $"&min_width={minWidth}";
            }
            if (minHeight > 0)
            {
                _requestUrl += $"&min_height={minHeight}";
            }
            if (minDurationSecs > 0)
            {
                _requestUrl += $"&min_duration={minDurationSecs}";
            }
            if (maxDurationSecs > 0)
            {
                _requestUrl += $"&max_duration={maxDurationSecs}";
            }


            HttpResponseMessage response = await client.GetAsync(_requestUrl);

            var output = await ProcessResult<VideoPage>(response);
            output.rateLimit = ProcessRateLimits(response);

            return output;
        }

        /// <summary>
        /// Retrieve a specific Video from its id.
        /// </summary>
        /// <param name="id">The id of the video you are requesting.</param>
        /// <returns></returns>
        public async Task<Video> GetVideoAsync(int id)
        {
            string _requestUrl = $"videos/videos/{id}";

            HttpResponseMessage response = await client.GetAsync(_requestUrl);

            return await ProcessResult<Video>(response);
        }

        private async Task<T> ProcessResult<T>(HttpResponseMessage response)
        {
            string responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {

                return JsonConvert.DeserializeObject<T>(responseBody);
            }

            throw new ErrorResponse(response.StatusCode, responseBody);
        }

        private RateLimit ProcessRateLimits(HttpResponseMessage response)
        {
            try
            {
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

                var _resetValue = response.Headers.TryGetValues("X-Ratelimit-Reset", out var vals1) ? vals1.FirstOrDefault() : null;
                var _limitValue = response.Headers.TryGetValues("X-Ratelimit-Limit", out var vals2) ? vals2.FirstOrDefault() : "0";
                var _remainingValue = response.Headers.TryGetValues("X-Ratelimit-Remaining", out var vals3) ? vals3.FirstOrDefault() : "0";

                var output = new RateLimit()
                {
                    Limit = Convert.ToInt64(_limitValue),
                    Remaining = Convert.ToInt64(_remainingValue),
                    Reset = _resetValue == null ? start.AddMilliseconds(Convert.ToInt64(_resetValue)).ToLocalTime() : start.ToLocalTime()
                };

                return output;
            }
            catch (Exception e) { }

            return null;
        }
    }
}
