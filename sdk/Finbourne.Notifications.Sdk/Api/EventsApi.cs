/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.838
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Model;

namespace Finbourne.Notifications.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event.
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <returns>EventDetails</returns>
        EventDetails CreateEvent(Object body);

        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <returns>ApiResponse of EventDetails</returns>
        ApiResponse<EventDetails> CreateEventWithHttpInfo(Object body);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EventDetails</returns>
        System.Threading.Tasks.Task<EventDetails> CreateEventAsync(Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EventDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<EventDetails>> CreateEventWithHttpInfoAsync(Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApi : IEventsApiSync, IEventsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EventsApi : IEventsApi
    {
        private Finbourne.Notifications.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(String basePath)
        {
            this.Configuration = Finbourne.Notifications.Sdk.Client.Configuration.MergeConfigurations(
                Finbourne.Notifications.Sdk.Client.GlobalConfiguration.Instance,
                new Finbourne.Notifications.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Notifications.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventsApi(Finbourne.Notifications.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Notifications.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Notifications.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EventsApi(Finbourne.Notifications.Sdk.Client.ISynchronousClient client, Finbourne.Notifications.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Notifications.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Finbourne.Notifications.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Finbourne.Notifications.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Finbourne.Notifications.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Finbourne.Notifications.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Finbourne.Notifications.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event. 
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <returns>EventDetails</returns>
        public EventDetails CreateEvent(Object body)
        {
            Finbourne.Notifications.Sdk.Client.ApiResponse<EventDetails> localVarResponse = CreateEventWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event. 
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <returns>ApiResponse of EventDetails</returns>
        public Finbourne.Notifications.Sdk.Client.ApiResponse<EventDetails> CreateEventWithHttpInfo(Object body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new Finbourne.Notifications.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EventsApi->CreateEvent");

            Finbourne.Notifications.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Notifications.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.838");

            // make the HTTP request
            var localVarResponse = this.Client.Post<EventDetails>("/api/events", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateEvent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event. 
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EventDetails</returns>
        public async System.Threading.Tasks.Task<EventDetails> CreateEventAsync(Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Notifications.Sdk.Client.ApiResponse<EventDetails> localVarResponse = await CreateEventWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] CreateEvent: Create a new event. 
        /// </summary>
        /// <exception cref="Finbourne.Notifications.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The data to create an event.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EventDetails)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Notifications.Sdk.Client.ApiResponse<EventDetails>> CreateEventWithHttpInfoAsync(Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new Finbourne.Notifications.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EventsApi->CreateEvent");


            Finbourne.Notifications.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Notifications.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Notifications.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.838");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<EventDetails>("/api/events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateEvent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}