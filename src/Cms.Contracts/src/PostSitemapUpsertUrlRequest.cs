using System;

namespace Cms.Contracts;

public sealed record PostSitemapUpsertUrlRequest(Guid Id, string Path, DateTime LastModified);
