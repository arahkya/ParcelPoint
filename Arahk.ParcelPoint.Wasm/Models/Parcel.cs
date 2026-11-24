namespace Arahk.ParcelPoint.Wasm.Models;

public class Parcel
{
    public string ParcelNumber { get; set; } = string.Empty;
    public string Provider { get; set; } = string.Empty;
    public string Status { get; set; } = ParcelStatuses.Ready;
    public string SenderName { get; set; } = string.Empty;
    public string SenderPhone { get; set; } = string.Empty;
    public string ReceiverName { get; set; } = string.Empty;
    public string ReceiverUnit { get; set; } = string.Empty;
    public string ReceiverPhone { get; set; } = string.Empty;
    public DateTime ReceivedDate { get; set; } = DateTime.Today;
    public string Notes { get; set; } = string.Empty;
}

public static class ParcelStatuses
{
    public const string Ready = "Ready";
    public const string Pending = "Pending";
}
