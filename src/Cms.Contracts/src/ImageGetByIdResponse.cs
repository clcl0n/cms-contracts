using System;
using Cms.Contracts.Constants;

namespace Cms.Contracts;

public sealed record ImageGetByIdResponse(
    Guid Id,
    string FileName,
    long SizeInBytes,
    ImageFormat Format
);
