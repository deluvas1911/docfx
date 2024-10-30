﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Docfx.Build.ResourceFiles;

public interface IResourceFileConfig
{
    bool IsResourceFile(string fileExtension);
}
