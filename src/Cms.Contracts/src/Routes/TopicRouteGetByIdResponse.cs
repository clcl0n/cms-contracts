using System;

namespace Cms.Contracts.Routes;

public sealed record TopicRouteGetByIdResponse(Guid Id, string FullPath);
