﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Web.Mvc;

[assembly: AssemblyTitle("System.Web.Mvc.dll")]
[assembly: AssemblyDescription("System.Web.Mvc.dll")]
[assembly: Guid("4b5f4208-c6b0-4c37-9a41-63325ffa52ad")]

[assembly: InternalsVisibleTo("System.Web.Mvc.Test, PublicKey=00240000048000009400000006020000002400005253413100040000010001001d5b85029a2d79382fbd3b4e2771d8a262fa569613e2f31d270f7ddff2301f40887db09a1a6ebd09f66eac441d9a6832f9ff2494ed523f1c36066bd3f55ae2a6f02f2a729b8ca3086a22a22690ecb161a86338ec638ccb938e8b233f515dc925553a3f0f504da0685335d119fb08b36f3dd0613b4e7cfec045ba982395822ade")]
[assembly: PreApplicationStartMethod(typeof(PreApplicationStartCode), "Start")]
[assembly: TypeForwardedTo(typeof(TagBuilder))]
[assembly: TypeForwardedTo(typeof(TagRenderMode))]
[assembly: TypeForwardedTo(typeof(HttpAntiForgeryException))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationEqualToRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRangeRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRegexRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRemoteRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRequiredRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationStringLengthRule))]
