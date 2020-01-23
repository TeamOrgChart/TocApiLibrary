// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamorgchart
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ChartsApi.
    /// </summary>
    public static partial class ChartsApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='version'>
            /// </param>
            public static IList<ChartDefinition> Get(this IChartsApi operations, string version)
            {
                return operations.GetAsync(version).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ChartDefinition>> GetAsync(this IChartsApi operations, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='version'>
            /// </param>
            public static ChartDefinition CreateChart(this IChartsApi operations, CreateChartModel model, string version)
            {
                return operations.CreateChartAsync(model, version).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ChartDefinition> CreateChartAsync(this IChartsApi operations, CreateChartModel model, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateChartWithHttpMessagesAsync(model, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='chartId'>
            /// </param>
            /// <param name='version'>
            /// </param>
            public static ChartDefinition Get1(this IChartsApi operations, string chartId, string version)
            {
                return operations.Get1Async(chartId, version).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='chartId'>
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ChartDefinition> Get1Async(this IChartsApi operations, string chartId, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get1WithHttpMessagesAsync(chartId, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='chartId'>
            /// </param>
            /// <param name='version'>
            /// </param>
            public static object Delete(this IChartsApi operations, string chartId, string version)
            {
                return operations.DeleteAsync(chartId, version).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='chartId'>
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteAsync(this IChartsApi operations, string chartId, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(chartId, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}