// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamorgchart
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PositionsApi operations.
    /// </summary>
    public partial interface IPositionsApi
    {
        /// <summary>
        /// Returns a list of the temporary, vacant or department chart
        /// positions defined for the chart
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// GET /api/v1/positions/53bec490-1cdc-42f5-8983-e6efe66dc685
        /// </remarks>
        /// <param name='chartId'>
        /// ID of the chart definition
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<ChartPosition>>> GetChartPositionsWithHttpMessagesAsync(string chartId, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new or updates an existing temporary, vacant or
        /// department positions in the chart.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// POST /api/v1/positions/53bec490-1cdc-42f5-8983-e6efe66dc685
        /// [{
        /// "Id": 0,
        /// "Name": "Harry Potter",
        /// "ManagerId": "xxx-eee-333-sss-",
        /// "FriendlyManagerId": "string",
        /// "Position": "string",
        /// "IsTempPosition": true,
        /// "ExpireDate": "2020-01-29T09:13:53.895Z",
        /// "UniqueId": "abc123",
        /// "ViewItem": "",
        /// "PictureUrl": "",
        /// "IsDepartment": false,
        /// "DepartmentTitle": "",
        /// "DepartmentText": ""
        /// }]
        /// </remarks>
        /// <param name='chartId'>
        /// ID of the chart definition
        /// </param>
        /// <param name='model'>
        /// Position model
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ChartPosition>> CreateChartPositionWithHttpMessagesAsync(string chartId, ChartPosition model, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a temporary, vacant or department position from the chart
        /// and returns a list of the remaining positions.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// DELETE
        /// /api/v1/positions/53bec490-1cdc-42f5-8983-e6efe66dc685?uniqueId=1234
        /// </remarks>
        /// <param name='chartId'>
        /// ID of the chart definition
        /// </param>
        /// <param name='uniqueId'>
        /// ID of the position
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<ChartPosition>>> DeleteChartPositionWithHttpMessagesAsync(string chartId, string uniqueId, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a single temporary, vacant or department position by ID.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// GET
        /// /api/v1/positions/53bec490-1cdc-42f5-8983-e6efe66dc685?uniqueId=1234
        /// </remarks>
        /// <param name='chartId'>
        /// ID of the chart definition
        /// </param>
        /// <param name='uniqueId'>
        /// ID of the position
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ChartPosition>> GetChartPositionByIdWithHttpMessagesAsync(string chartId, string uniqueId, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
