﻿/*
 * Copyright 2020 VMware, Inc.
 * SPDX-License-Identifier: EPL-2.0
 */

using SingletonClient;
using System.Reflection;



namespace CSharp
{
    class ValuesAllFalse
    {
        public static string BASE_RES_NAME = "Resources.Resource";
        public static Assembly assembly = typeof(ValuesAllFalse).Assembly;
    }

    public class UtilAllFalse
    {
        private static IRelease rel;
        private static int count = 1;

        public static void Init()
        {
            IConfig cfg = I18N.LoadConfig(
                ValuesAllFalse.BASE_RES_NAME, ValuesAllFalse.assembly, "SingletonAllFalse");
            rel = I18N.GetRelease(cfg);
        }


        public static IConfig Config()
        {
            return rel.GetConfig();
        }

        public static IExtension Extension()
        {
            return I18N.GetExtension();
        
        }

        public static IRelease Release()
        {
            return rel;
        }

        public static IReleaseMessages Messages()
        {
            return rel.GetMessages();
        }

        public static ITranslation Translation()
        {
            return rel.GetTranslation();
        }

        public static ISource Source(string component, string key, string source = null, string comment = null)
        {
            return rel.GetTranslation().CreateSource(component, key, source, comment);
        }
    }
}

