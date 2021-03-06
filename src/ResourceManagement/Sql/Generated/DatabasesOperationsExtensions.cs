// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DatabasesOperations.
    /// </summary>
    public static partial class DatabasesOperationsExtensions
    {
            /// <summary>
            /// Pauses a data warehouse.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the data warehouse to pause.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PauseAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PauseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resumes a data warehouse.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the data warehouse to resume.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResumeAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResumeWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new database or updates an existing database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be operated on (updated or created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> CreateOrUpdateAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> UpdateAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseUpdateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be retrieved.
            /// </param>
            /// <param name='expand'>
            /// A comma separated list of child objects to expand in the response. Possible
            /// properties: serviceTierAdvisors, transparentDataEncryption.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> GetAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, expand, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of databases in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='expand'>
            /// A comma separated list of child objects to expand in the response. Possible
            /// properties: serviceTierAdvisors, transparentDataEncryption.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of databases to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DatabaseInner>> ListByServerAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string expand = default(string), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, expand, filter, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a database inside of an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> GetByElasticPoolAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByElasticPoolWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of databases in an elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DatabaseInner>> ListByElasticPoolAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByElasticPoolWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a database inside of a recommented elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='recommendedElasticPoolName'>
            /// The name of the elastic pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> GetByRecommendedElasticPoolAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string recommendedElasticPoolName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByRecommendedElasticPoolWithHttpMessagesAsync(resourceGroupName, serverName, recommendedElasticPoolName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of databases inside a recommented elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='recommendedElasticPoolName'>
            /// The name of the recommended elastic pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DatabaseInner>> ListByRecommendedElasticPoolAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string recommendedElasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRecommendedElasticPoolWithHttpMessagesAsync(resourceGroupName, serverName, recommendedElasticPoolName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a bacpac into a new database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for importing a Bacpac into a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportResponseInner> ImportAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, ImportRequestInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportWithHttpMessagesAsync(resourceGroupName, serverName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an import operation that imports a bacpac into an existing
            /// database. The existing database must be empty.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to import into
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for importing a Bacpac into a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportResponseInner> CreateImportOperationAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, ImportExtensionRequestInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateImportOperationWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports a database to a bacpac.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be exported.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for exporting a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportResponseInner> ExportAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, ExportRequestInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns database metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Metric>> ListMetricsAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, filter, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns database metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<MetricDefinition>> ListMetricDefinitionsAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Renames a database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to rename.
            /// </param>
            /// <param name='id'>
            /// The target ID for the resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RenameAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RenameWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, id, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Pauses a data warehouse.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the data warehouse to pause.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPauseAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPauseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resumes a data warehouse.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the data warehouse to resume.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginResumeAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginResumeWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new database or updates an existing database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be operated on (updated or created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> BeginCreateOrUpdateAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> BeginUpdateAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseUpdateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a bacpac into a new database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for importing a Bacpac into a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportResponseInner> BeginImportAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, ImportRequestInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginImportWithHttpMessagesAsync(resourceGroupName, serverName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an import operation that imports a bacpac into an existing
            /// database. The existing database must be empty.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to import into
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for importing a Bacpac into a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportResponseInner> BeginCreateImportOperationAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, ImportExtensionRequestInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateImportOperationWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports a database to a bacpac.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database to be exported.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for exporting a database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportExportResponseInner> BeginExportAsync(this IDatabasesOperations operations, string resourceGroupName, string serverName, string databaseName, ExportRequestInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginExportWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
