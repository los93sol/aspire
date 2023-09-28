// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Dashboard.Model;

public interface IContainerLogSource
{
    IAsyncEnumerable<string[]> WatchLogsAsync(CancellationToken cancellationToken);
}
