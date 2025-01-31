// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Identity.Data;

/// <summary>
/// The response type for the "/manage/info" endpoints added by <see cref="IdentityApiEndpointRouteBuilderExtensions.MapIdentityApi"/>.
/// </summary>
public sealed class InfoResponse
{
    /// <summary>
    /// The email address associated with the authenticated user.
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// Indicates whether or not the <see cref="Email"/> has been confirmed yet.
    /// </summary>
    public required bool IsEmailConfirmed { get; init; }

    /// <summary>
    /// The <see cref="ClaimsPrincipal.Claims"/> from the authenticated <see cref="HttpContext.User"/>.
    /// </summary>
    public required IDictionary<string, string> Claims { get; init; }
}
