# Change log

## 1.0.10
* Upgrade Newtonsoft.Json to 13.0.1

## 1.0.9
* Added support for 'alt' on the 'Photo' model (thanks @gorgsenegger)
* Fix incorrect check / fallback on Rate Limit date (thanks @mattheww-freshview)

## 1.0.8
* Added support for returning featured collections

## 1.0.7
* Added `avgColor` (the average color of the photo) to the `Photo` object output
* Added `orientation`, `size` and `color` to the Photo Search parameters.
* Added `orientation`, `size` and `locale` to the Video Search parameters.
* Removed deprecated `minWidth`, `minHeight`, `minDuration`, `maxDuration` parameters from Video Search.

## 1.0.6
* Add support for returning collections belonging to the API user.
* Add support for returning media from a collection.
* Added `Pexels/.NET` `User-Agent` header to requests.

## 1.0.5
* Initial release.