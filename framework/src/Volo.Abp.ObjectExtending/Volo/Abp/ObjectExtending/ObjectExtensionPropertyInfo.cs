﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Volo.Abp.ObjectExtending
{
    public class ObjectExtensionPropertyInfo
    {
        [NotNull]
        public ObjectExtensionInfo ObjectExtension { get; }

        [NotNull]
        public string Name { get; }

        [NotNull]
        public Type Type { get; }

        [NotNull]
        public Dictionary<object, object> Configuration { get; }

        public ObjectExtensionPropertyInfo(
            [NotNull] ObjectExtensionInfo objectExtension, 
            [NotNull] Type type, 
            [NotNull] string name)
        {
            ObjectExtension = Check.NotNull(objectExtension, nameof(objectExtension));
            Type = Check.NotNull(type, nameof(type));
            Name = Check.NotNull(name, nameof(name));

            Configuration = new Dictionary<object, object>();
        }
    }
}
