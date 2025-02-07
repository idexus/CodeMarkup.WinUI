﻿using System;

namespace CodeMarkup.WinUI
{
    public static class PropertyContextExtension
    {
        // --- PropertyBindingBuilder ---

        public static PropertyBindingBuilder<T> Path<T>(this PropertyContext<T> self, string path)
            => new PropertyBindingBuilder<T>(self).Path(path);

        public static PropertyResourceBuilder<T> ResourceKey<T>(this PropertyContext<T> self, string key)
            => new PropertyResourceBuilder<T>(self).ResourceKey(key);

    }
}
