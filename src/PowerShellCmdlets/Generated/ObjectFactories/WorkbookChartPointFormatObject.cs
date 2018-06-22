// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartPointFormat&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartPointFormat&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartPointFormatObject", DefaultParameterSetName = @"#microsoft.graph.workbookChartPointFormat")]
    [ODataType("microsoft.graph.workbookChartPointFormat")]
    public class New_WorkbookChartPointFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartPointFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartFill")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookChartPointFormat", HelpMessage = @"The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.")]
        public System.Object fill { get; set; }
    }
}