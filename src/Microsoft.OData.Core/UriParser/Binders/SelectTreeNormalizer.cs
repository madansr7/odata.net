//---------------------------------------------------------------------
// <copyright file="SelectTreeNormalizer.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.Linq;

namespace Microsoft.OData.UriParser
{
    /// <summary>
    /// Translate a select tree into the right format to be used with an expand tree.
    /// </summary>
    internal sealed class SelectTreeNormalizer
    {
        /// <summary>
        /// Normalize a SelectToken into something that can be used to trim an expand tree.
        /// </summary>
        /// <param name="treeToNormalize">The select token to normalize</param>
        /// <returns>Normalized SelectToken</returns>
        public static SelectToken NormalizeSelectTree(SelectToken treeToNormalize)
        {
            treeToNormalize.Properties = treeToNormalize.Properties.Select(p => p.Reverse()).ToList();

            // to normalize a select token we just need to invert its paths, so that
            // we match the ordering on an ExpandToken.
            return treeToNormalize;
        }
    }
}