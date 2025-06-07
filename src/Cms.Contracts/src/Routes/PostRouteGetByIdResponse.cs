using System;

namespace Cms.Contracts.Routes;

public sealed record PostRouteGetByIdResponse(Guid Id, string FullPath);
