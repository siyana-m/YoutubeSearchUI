using Newtonsoft.Json;

namespace YoutubeSearchAppInterface.Models
{
    public class SearchResponse
    {

            [JsonProperty("kind")]
            public string Kind { get; set; } = string.Empty!;

            [JsonProperty("etag")]
            public string Etag { get; set; } = string.Empty!;

            [JsonProperty("nextPageToken")]
            public string NextPageToken { get; set; } = string.Empty!;

            [JsonProperty("regionCode")]
            public string RegionCode { get; set; } = string.Empty!;

            [JsonProperty("pageInfo")]
            public PageInfo PageInfo { get; set; }
            [JsonProperty("items")]
            public List<Item> Items { get; set; }
        }
        public partial class Item
        {
            [JsonProperty("kind")]
            public string Kind { get; set; } = string.Empty!;

            [JsonProperty("etag")]
            public string Etag { get; set; } = string.Empty!;

            [JsonProperty("id")]
            public Id Id { get; set; }

            [JsonProperty("snippet")]
            public Snippet Snippet { get; set; }
        }

        public partial class Id
        {
            [JsonProperty("kind")]
            public string Kind { get; set; } = string.Empty!;

            [JsonProperty("videoId")]
            public string VideoId { get; set; } = string.Empty!;
        }

        public partial class Snippet
        {
            [JsonProperty("publishedAt")]
            public DateTimeOffset PublishedAt { get; set; }

            [JsonProperty("channelId")]
            public string ChannelId { get; set; } = string.Empty!;

            [JsonProperty("title")]
            public string Title { get; set; } = string.Empty!;

            [JsonProperty("description")]
            public string Description { get; set; } = string.Empty!;

            [JsonProperty("thumbnails")]
            public Thumbnails Thumbnails { get; set; }

            [JsonProperty("channelTitle")]
            public string ChannelTitle { get; set; } = string.Empty!;

            [JsonProperty("liveBroadcastContent")]
            public string LiveBroadcastContent { get; set; } = string.Empty!;

            [JsonProperty("publishTime")]
            public DateTimeOffset PublishTime { get; set; }
        }


        public partial class Thumbnails
        {
            [JsonProperty("default")]
            public Default Default { get; set; }

            [JsonProperty("medium")]
            public Default Medium { get; set; }

            [JsonProperty("high")]
            public Default High { get; set; }
        }

        public partial class Default
        {
            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("width")]
            public long Width { get; set; }

            [JsonProperty("height")]
            public long Height { get; set; }
        }

        public partial class PageInfo
        {
            [JsonProperty("totalResults")]
            public long TotalResults { get; set; }

            [JsonProperty("resultsPerPage")]
            public long ResultsPerPage { get; set; }
        }
    }

