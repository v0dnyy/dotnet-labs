﻿namespace TransportMgmtServer.Dto;

public class TransportPostDto
{
    /// <summary>
    /// Transport state number
    /// </summary>
    public string StateNumber { get; set; } = string.Empty;
    /// <summary>
    /// Transport type id
    /// </summary>
    public int TypeId { get; set; } = 0;
    /// <summary>
    /// Transport model id
    /// </summary>
    public int ModelId { get; set; } = 0;
    /// <summary>
    /// Transport production date
    /// </summary>
    public DateTime DateMake { get; set; } = new DateTime();
}
