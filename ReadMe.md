
# Usage

Before starting...

Obtain a key from [https://www.pexels.com/api](https://www.pexels.com/api) by selecting 'Get Started'.
View full API documentation here [https://www.pexels.com/api/documentation](https://www.pexels.com/api/documentation). 

---

## Initialize Client:
`var client = new PexelsClient("[YOUR_API_KEY]");`

## Search Photos:
`var result = await pexelsClient.SearchPhotosAsync("nature");`

## Curated Photos:
`var result = await pexelsClient.CuratedPhotosAsync();`

## Get a Photo:
`var result = await pexelsClient.GetPhotoAsync(2014422);`

## Search Videos:
`var result = await pexelsClient.SearchVideosAsync("nature");`

## Popular Videos:
`var result = await pexelsClient.PopularVideosAsync();` 

## Get a Video:
`var result = await pexelsClient.GetVideoAsync(2499611);`
