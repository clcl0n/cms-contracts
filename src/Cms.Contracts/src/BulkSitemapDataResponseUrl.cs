using System;

namespace Cms.Contracts;

public sealed record BulkSitemapDataResponseUrl(Guid EntityId, string Path, DateTime LastModified);
