/*
 * Copyright (c) 2020 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System;

namespace Piranha.Data
{
    [Serializable]
    public sealed class Language
    {
        /// <summary>
        /// Gets/sets the unique id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets/sets the display title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets/sets the unique slug.
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Gets/sets the culture.
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Gets/sets if this is the default language.
        /// </summary>
        public bool IsDefault { get; set; }
    }
}