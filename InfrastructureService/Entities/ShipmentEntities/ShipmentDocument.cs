using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.ShipmentEntities;

/// <summary>
/// Документы грузоперевозки
/// </summary>
public class ShipmentDocument : BaseEntity
{
    /// <summary>
    /// Грузоперевозка
    /// </summary>
    public Shipment Shipment { get; set; } = null!;
    
    /// <summary>
    /// Необходимость оформления транзита
    /// </summary>
    public bool BTT { get; set; }
    
    /// <summary>
    /// Необходимость оформления домашнего коносамента
    /// </summary>
    public bool HBL { get; set; }
    
    /// <summary>
    /// Дата релиза HBL
    /// </summary>
    public DateTime ReleaseDateHBL { get; set; }
    
    /// <summary>
    /// Выкладка документов по товару 
    /// </summary>
    public bool Packing { get; set; }
    
    /// <summary>
    /// Дата выкладки документов по товару 
    /// </summary>
    public DateTime PackingDate { get; set; }

    /// <summary>
    /// Коносамент
    /// </summary>
    public string BillOfLading { get; set; } = null!;
    
    /// <summary>
    /// Подготовка коммерческих документов
    /// </summary>
    public string CommercialDocumentPreparation { get; set; } = null!;
    
    /// <summary>
    /// Дата Telex (telegraph exchange) релиза
    /// </summary>
    public DateTime Telex { get; set; }
    
    /// <summary>
    /// Дата отправки документов
    /// </summary>
    public DateTime SendDate { get; set; }
    
    /// <summary>
    /// Дата получения документов
    /// </summary>
    public  DateTime ReceiptDate { get; set; }
}