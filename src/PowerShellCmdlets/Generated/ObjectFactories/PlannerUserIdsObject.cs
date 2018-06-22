// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerUserIds&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerUserIds&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerUserIdsObject", DefaultParameterSetName = @"#microsoft.graph.plannerUserIds")]
    [ODataType("microsoft.graph.plannerUserIds")]
    public class New_PlannerUserIdsObject : ObjectFactoryCmdletBase
    {
    }
}