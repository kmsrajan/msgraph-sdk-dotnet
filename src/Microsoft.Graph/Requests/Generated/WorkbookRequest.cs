// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkbookRequest.
    /// </summary>
    public partial class WorkbookRequest : BaseRequest, IWorkbookRequest
    {
        /// <summary>
        /// Constructs a new WorkbookRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Workbook using POST.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <returns>The created Workbook.</returns>
        public System.Threading.Tasks.Task<Workbook> CreateAsync(Workbook workbookToCreate)
        {
            return this.CreateAsync(workbookToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Workbook using POST.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Workbook.</returns>
        public async System.Threading.Tasks.Task<Workbook> CreateAsync(Workbook workbookToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Workbook>(workbookToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Workbook.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Workbook>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Workbook.
        /// </summary>
        /// <returns>The Workbook.</returns>
        public System.Threading.Tasks.Task<Workbook> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Workbook.</returns>
        public async System.Threading.Tasks.Task<Workbook> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Workbook>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Workbook using PATCH.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <returns>The updated Workbook.</returns>
        public System.Threading.Tasks.Task<Workbook> UpdateAsync(Workbook workbookToUpdate)
        {
            return this.UpdateAsync(workbookToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Workbook using PATCH.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Workbook.</returns>
        public async System.Threading.Tasks.Task<Workbook> UpdateAsync(Workbook workbookToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Workbook>(workbookToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookToInitialize">The <see cref="Workbook"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Workbook workbookToInitialize)
        {

            if (workbookToInitialize != null && workbookToInitialize.AdditionalData != null)
            {

                if (workbookToInitialize.Names != null && workbookToInitialize.Names.CurrentPage != null)
                {
                    workbookToInitialize.Names.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("names@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Names.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookToInitialize.Tables != null && workbookToInitialize.Tables.CurrentPage != null)
                {
                    workbookToInitialize.Tables.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("tables@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Tables.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookToInitialize.Worksheets != null && workbookToInitialize.Worksheets.CurrentPage != null)
                {
                    workbookToInitialize.Worksheets.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("worksheets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Worksheets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}