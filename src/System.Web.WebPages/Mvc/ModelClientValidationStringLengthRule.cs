﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;

namespace System.Web.Mvc
{
    [TypeForwardedFrom("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=2f9147bba06de483")]
    public class ModelClientValidationStringLengthRule : ModelClientValidationRule
    {
        public ModelClientValidationStringLengthRule(string errorMessage, int minimumLength, int maximumLength)
        {
            ErrorMessage = errorMessage;
            ValidationType = "length";

            if (minimumLength != 0)
            {
                ValidationParameters["min"] = minimumLength;
            }

            if (maximumLength != Int32.MaxValue)
            {
                ValidationParameters["max"] = maximumLength;
            }
        }
    }
}
