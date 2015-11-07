// ------------------------------------------------------------------------------
//  Copyright (c) 2015 Microsoft Corporation
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.OneDrive.Sdk
{
    using System.Collections.Generic;

    /// <summary>
    /// The type ItemsCollectionRequestBuilder.
    /// </summary>
    public partial class ItemsCollectionRequestBuilder : BaseRequestBuilder, IItemsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ItemsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="oneDriveClient">The <see cref="IOneDriveClient"/> for handling requests.</param>
        public ItemsCollectionRequestBuilder(
            string requestUrl,
            IOneDriveClient oneDriveClient)
            : base(requestUrl, oneDriveClient)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IItemsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IItemsCollectionRequest Request(IList<Option> options)
        {
            return new ItemsCollectionRequest(this.RequestUrl, this.OneDriveClient, options);
        }

        /// <summary>
        /// Gets an <see cref="IItemRequestBuilder"/> for the specified Items.
        /// </summary>
        /// <param name="id">The ID for the Items.</param>
        /// <returns>The <see cref="IItemRequestBuilder"/>.</returns>
        public IItemRequestBuilder this[string id]
        {
            get
            {
                return new ItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.OneDriveClient);
            }
        }
    }
}