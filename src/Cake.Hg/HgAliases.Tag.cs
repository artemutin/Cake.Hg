﻿using System;
using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace Cake.Hg
{
    public static partial class HgAliases
    {
        /// <summary>
        /// Apply a symbolic identifier for a changeset [tag]. 
        /// </summary>
        /// <example>
        /// <code>
        ///     HgTag("./", "0.0.1");
        /// </code>
        /// </example>
        /// <param name="context">Cake context</param>
        /// <param name="repositoryPath">Path to repository</param>
        /// <param name="tagName">Tag name</param>
        [CakeMethodAlias]
        [CakeAliasCategory("Tag")]
        public static void HgTag(this ICakeContext context, DirectoryPath repositoryPath, string tagName)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (repositoryPath == null) throw new ArgumentNullException(nameof(repositoryPath));
            if (tagName == null) throw new ArgumentNullException(nameof(tagName));

            context.Hg(repositoryPath).Tag(tagName);
        }
    }
}