﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TORA_Affiliation.Queries {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Queries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Queries() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TORA_Affiliation.Queries.Queries", typeof(Queries).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET XACT_ABORT ON
        ///DECLARE @TranName VARCHAR(50) = &apos;AffiliationServiceAggration&apos;;
        ///
        ///-- IF PreAggregationAffi table exists, delete it
        ///IF OBJECT_ID(&apos;tempdb..#PreAggregationAffi&apos;) IS NOT NULL DROP TABLE #PreAggregationAffi
        ///
        ///BEGIN TRANSACTION @TranName; 
        ///
        ///-- Fill the PreAggregationAffi table while adding InvoicingID and SelfBillingID
        ///select ID
        ///     , InvoicingID = ( case when PaymentMethod = 2
        ///                            then ( select U_TORA_TIC_RetailBp COLLATE SQL_Latin1_General_CP850_CI_AS
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AddEntriesToAffiliation {
            get {
                return ResourceManager.GetString("AddEntriesToAffiliation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select ID
        ///     , TransactionTypeID
        ///     , TransactionDate
        ///     , InvoicingID
        ///     , ProductID
        ///     , Quantity
        ///     , PaymentMethod
        ///     , TransactionAmount
        ///     , CommissionAmount
        ///     , [Count]
        ///from AffiTransactions.
        /// </summary>
        internal static string GetAffiTransations {
            get {
                return ResourceManager.GetString("GetAffiTransations", resourceCulture);
            }
        }
    }
}
