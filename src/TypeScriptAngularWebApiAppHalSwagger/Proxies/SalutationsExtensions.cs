// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TypeScriptAngularWebApiAppHalSwagger.Proxies
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class SalutationsExtensions
    {
            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SalutationCollectionModel Get(this ISalutations operations)
            {
                return Task.Factory.StartNew(s => ((ISalutations)s).GetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SalutationCollectionModel> GetAsync( this ISalutations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<SalutationCollectionModel> result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
