﻿using Cake.Core.IO;

namespace Cake.SqlPackage
{
    /// <summary>
    /// Contains settings used by <see cref="SqlPackagePublishSettings" />.
    /// </summary>
    public class SqlPackagePublishSettings : SqlPackageSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlPackagePublishSettings"/> class.
        /// </summary>
        public SqlPackagePublishSettings()
        {
            _action = SqlPackageAction.Publish;
        }

        /// <summary>
        /// Specifies the Client Secret to be used in authenticating against Azure Key Vault.
        /// </summary>
        public string AzureSecret { get; set; }

        /// <summary>
        /// Specifies what authentication method will be used for accessing Azure Key Vault.
        /// </summary>
        public AzureKeyVaultAuthMethod? AzureKeyVaultAuthMethod { get; set; }

        /// <summary>
        /// Specifies the Client ID to be used in authenticating against Azure Key Vault.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Specifies an optional file path to output the deployment script.
        /// </summary>
        public FilePath DeployScriptPath { get; set; }

        // OutputPath is not a valid SqlPackage.exe option for the Publish action, so hide it.
        private new FilePath OutputPath { get; set; }
    }
}
