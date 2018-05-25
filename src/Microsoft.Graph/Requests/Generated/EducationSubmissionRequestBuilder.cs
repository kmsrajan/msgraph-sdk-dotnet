// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EducationSubmissionRequestBuilder.
    /// </summary>
    public partial class EducationSubmissionRequestBuilder : EntityRequestBuilder, IEducationSubmissionRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationSubmissionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationSubmissionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEducationSubmissionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEducationSubmissionRequest Request(IEnumerable<Option> options)
        {
            return new EducationSubmissionRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Resources.
        /// </summary>
        /// <returns>The <see cref="IEducationSubmissionResourcesCollectionRequestBuilder"/>.</returns>
        public IEducationSubmissionResourcesCollectionRequestBuilder Resources
        {
            get
            {
                return new EducationSubmissionResourcesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("resources"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SubmittedResources.
        /// </summary>
        /// <returns>The <see cref="IEducationSubmissionSubmittedResourcesCollectionRequestBuilder"/>.</returns>
        public IEducationSubmissionSubmittedResourcesCollectionRequestBuilder SubmittedResources
        {
            get
            {
                return new EducationSubmissionSubmittedResourcesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("submittedResources"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for EducationSubmissionRecall.
        /// </summary>
        /// <returns>The <see cref="IEducationSubmissionRecallRequestBuilder"/>.</returns>
        public IEducationSubmissionRecallRequestBuilder Recall()
        {
            return new EducationSubmissionRecallRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.recall"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EducationSubmissionRelease.
        /// </summary>
        /// <returns>The <see cref="IEducationSubmissionReleaseRequestBuilder"/>.</returns>
        public IEducationSubmissionReleaseRequestBuilder Release()
        {
            return new EducationSubmissionReleaseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.release"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EducationSubmissionSubmit.
        /// </summary>
        /// <returns>The <see cref="IEducationSubmissionSubmitRequestBuilder"/>.</returns>
        public IEducationSubmissionSubmitRequestBuilder Submit()
        {
            return new EducationSubmissionSubmitRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.submit"),
                this.Client);
        }
    
    }
}