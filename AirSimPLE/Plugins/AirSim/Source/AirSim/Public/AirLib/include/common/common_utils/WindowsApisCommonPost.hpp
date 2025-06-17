// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

//there is no #pragma once in this header

//following is required to support Unreal Build System on Windows
//the order of the headers is according to https://learn.microsoft.com/en-us/windows/mixed-reality/develop/unreal/unreal-winrt
#if (defined _WIN32 || defined _WIN64) && (defined UE_GAME || defined UE_EDITOR)
#pragma warning(pop)
#include "Windows/PostWindowsApi.h"
#include "Windows/HideWindowsPlatformAtomics.h"
#include "Windows/HideWindowsPlatformTypes.h"
#endif
