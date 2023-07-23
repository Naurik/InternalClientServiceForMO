using System;
using System.Collections.Generic;

namespace Service.DATA.Models;

public partial class DigitalSignAttribute
{
    public long Id { get; set; }

    public int AttributeType { get; set; }

    public int Order { get; set; }

    public string FieldName { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Prefix { get; set; }

    public int? Type { get; set; }
}
