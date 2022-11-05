using System.Text.Json.Serialization;

namespace Ple;

public class WebInfo
{
    [JsonPropertyName("initialData")]
    public List<InitialDatumClass> InitialData { get; set; }
}

public class AttributeClass
{
    [JsonPropertyName("Key")]
    public string Key { get; set; }

    [JsonPropertyName("Value")]
    public string Value { get; set; }

    [JsonPropertyName("Values")]
    public List<object> Values { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("AttributeType")]
    public string AttributeType { get; set; }

    [JsonPropertyName("Group")]
    public string Group { get; set; }

    [JsonPropertyName("ShowOnWeb")]
    public bool ShowOnWeb { get; set; }
}

public class AttributeListClass
{
    [JsonPropertyName("Key")]
    public string Key { get; set; }

    [JsonPropertyName("Value")]
    public string Value { get; set; }

    [JsonPropertyName("Values")]
    public List<string> Values { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("AttributeType")]
    public string AttributeType { get; set; }

    [JsonPropertyName("Group")]
    public string Group { get; set; }

    [JsonPropertyName("ShowOnWeb")]
    public bool ShowOnWeb { get; set; }
}

public class AvailabilityClass
{
    [JsonPropertyName("LocationCode")]
    public string LocationCode { get; set; }

    [JsonPropertyName("Location")]
    public string Location { get; set; }

    [JsonPropertyName("State")]
    public string State { get; set; }

    [JsonPropertyName("Availability")]
    public string Availability { get; set; }

    [JsonPropertyName("InStock")]
    public bool InStock { get; set; }

    [JsonPropertyName("InventoryWarehouseId")]
    public int InventoryWarehouseId { get; set; }

    [JsonPropertyName("Available")]
    public bool Available { get; set; }

    [JsonPropertyName("AvailableAfterTransfer")]
    public bool AvailableAfterTransfer { get; set; }

    [JsonPropertyName("ETA")]
    public DateTime ETA { get; set; }
}

public class BadgesNewClass
{
    [JsonPropertyName("BadgeCategoryId")]
    public int BadgeCategoryId { get; set; }

    [JsonPropertyName("BadgeImageId")]
    public int BadgeImageId { get; set; }

    [JsonPropertyName("BadgeCode")]
    public string BadgeCode { get; set; }

    [JsonPropertyName("BadgeDisplayName")]
    public string BadgeDisplayName { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }
}

public class CategoryListClass
{
    [JsonPropertyName("InventoryCategoryId")]
    public int InventoryCategoryId { get; set; }

    [JsonPropertyName("ParentCategoryId")]
    public int ParentCategoryId { get; set; }

    [JsonPropertyName("CategoryName")]
    public string CategoryName { get; set; }

    [JsonPropertyName("WebListingBadgeBinaryObjectId")]
    public int WebListingBadgeBinaryObjectId { get; set; }

    [JsonPropertyName("Url")]
    public string Url { get; set; }

    [JsonPropertyName("InventoryItemId")]
    public int InventoryItemId { get; set; }

    [JsonPropertyName("ChildCategories")]
    public List<ChildCategoryClass> ChildCategories { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("InventoryCategoryGroupId")]
    public int InventoryCategoryGroupId { get; set; }
}

public class ChildCategoryClass
{
    [JsonPropertyName("InventoryCategoryId")]
    public int InventoryCategoryId { get; set; }

    [JsonPropertyName("ParentCategoryId")]
    public int ParentCategoryId { get; set; }

    [JsonPropertyName("CategoryName")]
    public string CategoryName { get; set; }

    [JsonPropertyName("WebListingBadgeBinaryObjectId")]
    public int WebListingBadgeBinaryObjectId { get; set; }

    [JsonPropertyName("Url")]
    public string Url { get; set; }

    [JsonPropertyName("InventoryItemId")]
    public int InventoryItemId { get; set; }

    [JsonPropertyName("ChildCategories")]
    public List<ChildCategoryClass> ChildCategories { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("InventoryCategoryGroupId")]
    public int InventoryCategoryGroupId { get; set; }
}

public class InitialDatumClass
{
    [JsonPropertyName("searchGridData")]
    public SearchGridDataClass SearchGridData { get; set; }
}

public class ItemDatumClass
{
    [JsonPropertyName("InventoryItemId")]
    public int InventoryItemId { get; set; }

    [JsonPropertyName("ItemCode")]
    public string ItemCode { get; set; }

    [JsonPropertyName("ItemDescription")]
    public string ItemDescription { get; set; }

    [JsonPropertyName("RetailPriceIncTax")]
    public int RetailPriceIncTax { get; set; }

    [JsonPropertyName("CustomerPriceIncTax")]
    public int CustomerPriceIncTax { get; set; }

    [JsonPropertyName("RRPPriceIncTax")]
    public double RRPPriceIncTax { get; set; }

    [JsonPropertyName("ManufacturerId")]
    public int ManufacturerId { get; set; }

    [JsonPropertyName("ManufacturerName")]
    public string ManufacturerName { get; set; }

    [JsonPropertyName("ManufacturerModel")]
    public string ManufacturerModel { get; set; }

    [JsonPropertyName("ItemTypeCode")]
    public string ItemTypeCode { get; set; }

    [JsonPropertyName("AgeRank")]
    public int AgeRank { get; set; }

    [JsonPropertyName("AlphaRank")]
    public int AlphaRank { get; set; }

    [JsonPropertyName("PopularityRank")]
    public int PopularityRank { get; set; }

    [JsonPropertyName("Relevance")]
    public int Relevance { get; set; }

    [JsonPropertyName("InStock")]
    public bool InStock { get; set; }

    [JsonPropertyName("ItemUrl")]
    public string ItemUrl { get; set; }

    [JsonPropertyName("PrimaryImageId")]
    public int PrimaryImageId { get; set; }

    [JsonPropertyName("SecondaryImageId")]
    public int SecondaryImageId { get; set; }

    [JsonPropertyName("MarketingDescription")]
    public string MarketingDescription { get; set; }

    [JsonPropertyName("BuyButtonText")]
    public string BuyButtonText { get; set; }

    [JsonPropertyName("BuyButtonLink")]
    public string BuyButtonLink { get; set; }

    [JsonPropertyName("FreeShipping")]
    public bool FreeShipping { get; set; }

    [JsonPropertyName("BadgesNew")]
    public List<BadgesNewClass> BadgesNew { get; set; }

    [JsonPropertyName("Badges")]
    public List<string> Badges { get; set; }

    [JsonPropertyName("Availabilities")]
    public List<AvailabilityClass> Availabilities { get; set; }

    [JsonPropertyName("Attributes")]
    public List<AttributeClass> Attributes { get; set; }

    [JsonPropertyName("WebListingStrip")]
    public string WebListingStrip { get; set; }

    [JsonPropertyName("HidePriceFromCategoryListing")]
    public bool HidePriceFromCategoryListing { get; set; }

    [JsonPropertyName("Categories")]
    public List<int> Categories { get; set; }

    [JsonPropertyName("AvailableOnline")]
    public bool AvailableOnline { get; set; }

    [JsonPropertyName("ItemPlainDescription")]
    public string ItemPlainDescription { get; set; }
}

public class ManufacturerListClass
{
    [JsonPropertyName("ManufacturerId")]
    public int ManufacturerId { get; set; }

    [JsonPropertyName("ManufacturerName")]
    public string ManufacturerName { get; set; }
}

public class OriginalDatumClass
{
    [JsonPropertyName("InventoryItemId")]
    public int InventoryItemId { get; set; }

    [JsonPropertyName("ItemCode")]
    public string ItemCode { get; set; }

    [JsonPropertyName("ItemDescription")]
    public string ItemDescription { get; set; }

    [JsonPropertyName("RetailPriceIncTax")]
    public int RetailPriceIncTax { get; set; }

    [JsonPropertyName("CustomerPriceIncTax")]
    public int CustomerPriceIncTax { get; set; }

    [JsonPropertyName("RRPPriceIncTax")]
    public double RRPPriceIncTax { get; set; }

    [JsonPropertyName("ManufacturerId")]
    public int ManufacturerId { get; set; }

    [JsonPropertyName("ManufacturerName")]
    public string ManufacturerName { get; set; }

    [JsonPropertyName("ManufacturerModel")]
    public string ManufacturerModel { get; set; }

    [JsonPropertyName("ItemTypeCode")]
    public string ItemTypeCode { get; set; }

    [JsonPropertyName("AgeRank")]
    public int AgeRank { get; set; }

    [JsonPropertyName("AlphaRank")]
    public int AlphaRank { get; set; }

    [JsonPropertyName("PopularityRank")]
    public int PopularityRank { get; set; }

    [JsonPropertyName("Relevance")]
    public int Relevance { get; set; }

    [JsonPropertyName("InStock")]
    public bool InStock { get; set; }

    [JsonPropertyName("ItemUrl")]
    public string ItemUrl { get; set; }

    [JsonPropertyName("PrimaryImageId")]
    public int PrimaryImageId { get; set; }

    [JsonPropertyName("SecondaryImageId")]
    public int SecondaryImageId { get; set; }

    [JsonPropertyName("MarketingDescription")]
    public string MarketingDescription { get; set; }

    [JsonPropertyName("BuyButtonText")]
    public string BuyButtonText { get; set; }

    [JsonPropertyName("BuyButtonLink")]
    public string BuyButtonLink { get; set; }

    [JsonPropertyName("FreeShipping")]
    public bool FreeShipping { get; set; }

    [JsonPropertyName("BadgesNew")]
    public List<BadgesNewClass> BadgesNew { get; set; }

    [JsonPropertyName("Badges")]
    public List<string> Badges { get; set; }

    [JsonPropertyName("Availabilities")]
    public List<AvailabilityClass> Availabilities { get; set; }

    [JsonPropertyName("Attributes")]
    public List<AttributeClass> Attributes { get; set; }

    [JsonPropertyName("WebListingStrip")]
    public string WebListingStrip { get; set; }

    [JsonPropertyName("HidePriceFromCategoryListing")]
    public bool HidePriceFromCategoryListing { get; set; }

    [JsonPropertyName("Categories")]
    public List<int> Categories { get; set; }

    [JsonPropertyName("AvailableOnline")]
    public bool AvailableOnline { get; set; }

    [JsonPropertyName("ItemPlainDescription")]
    public string ItemPlainDescription { get; set; }
}

public class SearchGridDataClass
{
    [JsonPropertyName("originalData")]
    public List<OriginalDatumClass> OriginalData { get; set; }

    [JsonPropertyName("itemData")]
    public List<ItemDatumClass> ItemData { get; set; }

    [JsonPropertyName("manufacturerList")]
    public List<ManufacturerListClass> ManufacturerList { get; set; }

    [JsonPropertyName("attributeList")]
    public List<AttributeListClass> AttributeList { get; set; }

    [JsonPropertyName("categoryList")]
    public List<CategoryListClass> CategoryList { get; set; }

    [JsonPropertyName("minPrice")]
    public int MinPrice { get; set; }

    [JsonPropertyName("maxPrice")]
    public int MaxPrice { get; set; }

    [JsonPropertyName("upperOutlierPrice")]
    public double UpperOutlierPrice { get; set; }
}

