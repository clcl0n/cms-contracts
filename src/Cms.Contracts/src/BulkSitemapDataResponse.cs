using System.Collections.Generic;

namespace Cms.Contracts;

public sealed record BulkSitemapDataResponse(
    int Offset,
    int Limit,
    int Total,
    List<BulkSitemapDataResponseUrl> Urls
);
