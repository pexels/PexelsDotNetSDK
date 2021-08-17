
# Usage

Before starting...

Obtain a key from [https://www.pexels.com/api](https://www.pexels.com/api) by selecting 'Get Started'.
View full API documentation here [https://www.pexels.com/api/documentation](https://www.pexels.com/api/documentation). 

Install this via nuget: [https://www.nuget.org/packages/PexelsDotNetSDK/](https://www.nuget.org/packages/PexelsDotNetSDK/).

---

## Initialize Client:
`var pexelsClient = new PexelsClient("[YOUR_API_KEY]");`

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

## Get Collections:

Note: this is limited to collections belonging to the API user.

`var result = await pexelsClient.CollectionsAsync();`

## Get Featured Collections:

`var result = await pexelsClient.FeaturedCollectionsAsync();`

## Get all media for a collection

`var result = await pexelsClient.GetCollectionAsync("[your collection id]");`

You can also filter by `type` i.e. `photos` or `videos`:

`var result = await pexelsClient.GetCollectionAsync(id: "[your collection id]", type: "photos");`