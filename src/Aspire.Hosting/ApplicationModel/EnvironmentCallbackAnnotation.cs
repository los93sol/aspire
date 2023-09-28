// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Hosting.ApplicationModel;

public class EnvironmentCallbackAnnotation : IDistributedApplicationComponentAnnotation
{
    public EnvironmentCallbackAnnotation(string name, Func<string> callback)
    {
        Callback = (d) => d[name] = callback();
    }

    public EnvironmentCallbackAnnotation(Action<Dictionary<string, string>> callback)
    {
        Callback = callback;
    }

    public Action<Dictionary<string, string>> Callback { get; private set; }
}
