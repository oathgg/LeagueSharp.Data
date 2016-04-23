﻿namespace LeagueSharp.Data.DataTypes
{
    using System.Collections.Generic;
    using System.Text;

    using LeagueSharp.Data.Utility.Resources;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ItemDatabase : IDataType
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="ItemDatabase" /> class from being created.
        /// </summary>
        private ItemDatabase()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the items.
        /// </summary>
        /// <value>
        ///     The items.
        /// </value>
        /// <remarks>The Dictionary's key is the id of the item.</remarks>
        public IReadOnlyDictionary<int, ItemDatabaseEntry> Items => ItemDictionary;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the item dictionary.
        /// </summary>
        /// <value>
        ///     The item dictionary.
        /// </value>
        private static Dictionary<int, ItemDatabaseEntry> ItemDictionary { get; set; }

        #endregion

        #region Public Indexers

        /// <summary>
        ///     Gets the <see cref="ItemDatabaseEntry" /> with the specified identifier.
        /// </summary>
        /// <value>
        ///     The <see cref="ItemDatabaseEntry" />.
        /// </value>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ItemDatabaseEntry this[ItemId id] => ItemDictionary[(int)id];

        /// <summary>
        ///     Gets the <see cref="ItemDatabaseEntry" /> with the specified identifier.
        /// </summary>
        /// <value>
        ///     The <see cref="ItemDatabaseEntry" />.
        /// </value>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ItemDatabaseEntry this[int id] => ItemDictionary[id];

        #endregion

        #region Explicit Interface Methods

        /// <summary>
        ///     Initializes this instance.
        /// </summary>
        void IDataType.Initialize()
        {
            ItemDictionary =
                JObject.Parse(Encoding.Default.GetString(ResourceFactory.ByteResource("ItemData.json")))["data"]
                    .ToObject<Dictionary<int, ItemDatabaseEntry>>();
        }

        #endregion
    }

    public class ItemGold
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the amount of gold the item costs if all of the recipe is owned.
        /// </summary>
        /// <value>
        ///     Thethe amount of gold the item costs if all of the recipe is owned.
        /// </value>
        [JsonProperty("base")]
        public int Base { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="ItemGold" /> is purchasable.
        /// </summary>
        /// <value>
        ///     <c>true</c> if purchasable; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }

        /// <summary>
        ///     Gets or sets the amount of gold the item will sell for.
        /// </summary>
        /// <value>
        ///     The sell amount.
        /// </value>
        [JsonProperty("sell")]
        public int Sell { get; set; }

        /// <summary>
        ///     Gets or sets the total amount of gold the item costs.
        /// </summary>
        /// <value>
        ///     The total amount of gold the item costs.
        /// </value>
        [JsonProperty("total")]
        public int Total { get; set; }

        #endregion
    }

    public class ItemStats
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the flat armor modifier.
        /// </summary>
        /// <value>
        ///     The flat armor modifier.
        /// </value>
        [JsonProperty("FlatArmorMod")]
        public int FlatArmorMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat attack speed modifier.
        /// </summary>
        /// <value>
        ///     The flat attack speed modifier.
        /// </value>
        [JsonProperty("FlatAttackSpeedMod")]
        public int FlatAttackSpeedMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat block modifier.
        /// </summary>
        /// <value>
        ///     The flat block modifier.
        /// </value>
        [JsonProperty("FlatBlockMod")]
        public int FlatBlockMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat crit chance modifier.
        /// </summary>
        /// <value>
        ///     The flat crit chance modifier.
        /// </value>
        [JsonProperty("FlatCritChanceMod")]
        public int FlatCritChanceMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat crit damage modifier.
        /// </summary>
        /// <value>
        ///     The flat crit damage modifier.
        /// </value>
        [JsonProperty("FlatCritDamageMod")]
        public int FlatCritDamageMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat energy pool modifier.
        /// </summary>
        /// <value>
        ///     The flat energy pool modifier.
        /// </value>
        [JsonProperty("FlatEnergyPoolMod")]
        public int FlatEnergyPoolMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat energy regneration modifier.
        /// </summary>
        /// <value>
        ///     The flat energy regneration modifier.
        /// </value>
        [JsonProperty("FlatEnergyRegenMod")]
        public int FlatEnergyRegenMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat experience bonus.
        /// </summary>
        /// <value>
        ///     The flat experience bonus.
        /// </value>
        [JsonProperty("FlatEXPBonus")]
        public int FlatExpBonus { get; set; }

        /// <summary>
        ///     Gets or sets the flat health point pool modifier.
        /// </summary>
        /// <value>
        ///     The flat health point pool modifier.
        /// </value>
        [JsonProperty("FlatHPPoolMod")]
        public int FlatHpPoolMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat health point regneration modifier.
        /// </summary>
        /// <value>
        ///     The flat health point regneration modifier.
        /// </value>
        [JsonProperty("FlatHPRegenMod")]
        public int FlatHpRegenMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat magic damage modifier.
        /// </summary>
        /// <value>
        ///     The flat magic damage modifier.
        /// </value>
        [JsonProperty("FlatMagicDamageMod")]
        public int FlatMagicDamageMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat movement speed modifier.
        /// </summary>
        /// <value>
        ///     The flat movement speed modifier.
        /// </value>
        [JsonProperty("FlatMovementSpeedMod")]
        public int FlatMovementSpeedMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat mana point pool modifier.
        /// </summary>
        /// <value>
        ///     The flat mana point pool modifier.
        /// </value>
        [JsonProperty("FlatMPPoolMod")]
        public int FlatMpPoolMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat mana point regneration modifier.
        /// </summary>
        /// <value>
        ///     The flat mana point regneration modifier.
        /// </value>
        [JsonProperty("FlatMPRegenMod")]
        public int FlatMpRegenMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat physical damage modifier.
        /// </summary>
        /// <value>
        ///     The flat physical damage modifier.
        /// </value>
        [JsonProperty("FlatPhysicalDamageMod")]
        public int FlatPhysicalDamageMod { get; set; }

        /// <summary>
        ///     Gets or sets the flat spell block modifier.
        /// </summary>
        /// <value>
        ///     The flat spell block modifier.
        /// </value>
        [JsonProperty("FlatSpellBlockMod")]
        public int FlatSpellBlockMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent armor modifier.
        /// </summary>
        /// <value>
        ///     The percent armor modifier.
        /// </value>
        [JsonProperty("PercentArmorMod")]
        public int PercentArmorMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent attack speed modifier.
        /// </summary>
        /// <value>
        ///     The percent attack speed modifier.
        /// </value>
        [JsonProperty("PercentAttackSpeedMod")]
        public int PercentAttackSpeedMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent block modifier.
        /// </summary>
        /// <value>
        ///     The percent block modifier.
        /// </value>
        [JsonProperty("PercentBlockMod")]
        public int PercentBlockMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent crit chance modifier.
        /// </summary>
        /// <value>
        ///     The percent crit chance modifier.
        /// </value>
        [JsonProperty("PercentCritChanceMod")]
        public int PercentCritChanceMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent crit damage modifier.
        /// </summary>
        /// <value>
        ///     The percent crit damage modifier.
        /// </value>
        [JsonProperty("PercentCritDamageMod")]
        public int PercentCritDamageMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent dodge modifier.
        /// </summary>
        /// <value>
        ///     The percent dodge modifier.
        /// </value>
        [JsonProperty("PercentDodgeMod")]
        public int PercentDodgeMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent exp bonus.
        /// </summary>
        /// <value>
        ///     The percent exp bonus.
        /// </value>
        [JsonProperty("PercentEXPBonus")]
        public int PercentExpBonus { get; set; }

        /// <summary>
        ///     Gets or sets the percent health point pool modifier.
        /// </summary>
        /// <value>
        ///     The percent health point pool modifier.
        /// </value>
        [JsonProperty("PercentHPPoolMod")]
        public int PercentHpPoolMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent health point regneration modifier.
        /// </summary>
        /// <value>
        ///     The percent health point regneration modifier.
        /// </value>
        [JsonProperty("PercentHPRegenMod")]
        public int PercentHpRegenMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent life steal modifier.
        /// </summary>
        /// <value>
        ///     The percent life steal modifier.
        /// </value>
        [JsonProperty("PercentLifeStealMod")]
        public int PercentLifeStealMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent magic damage modifier.
        /// </summary>
        /// <value>
        ///     The percent magic damage modifier.
        /// </value>
        [JsonProperty("PercentMagicDamageMod")]
        public int PercentMagicDamageMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent movement speed modifier.
        /// </summary>
        /// <value>
        ///     The percent movement speed modifier.
        /// </value>
        [JsonProperty("PercentMovementSpeedMod")]
        public int PercentMovementSpeedMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent mana point pool modifier.
        /// </summary>
        /// <value>
        ///     The percent mana point pool modifier.
        /// </value>
        [JsonProperty("PercentMPPoolMod")]
        public int PercentMpPoolMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent mana point regneration modifier.
        /// </summary>
        /// <value>
        ///     The percent mana point regneration modifier.
        /// </value>
        [JsonProperty("PercentMPRegenMod")]
        public int PercentMpRegenMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent physical damage modifier.
        /// </summary>
        /// <value>
        ///     The percent physical damage modifier.
        /// </value>
        [JsonProperty("PercentPhysicalDamageMod")]
        public int PercentPhysicalDamageMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent spell block modifier.
        /// </summary>
        /// <value>
        ///     The percent spell block modifier.
        /// </value>
        [JsonProperty("PercentSpellBlockMod")]
        public int PercentSpellBlockMod { get; set; }

        /// <summary>
        ///     Gets or sets the percent spell vamp modifier.
        /// </summary>
        /// <value>
        ///     The percent spell vamp modifier.
        /// </value>
        [JsonProperty("PercentSpellVampMod")]
        public int PercentSpellVampMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat armor modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat armor modifier per level.
        /// </value>
        [JsonProperty("rFlatArmorModPerLevel")]
        public int RFlatArmorModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat armor penetration modifier.
        /// </summary>
        /// <value>
        ///     The rune flat armor penetration modifier.
        /// </value>
        [JsonProperty("rFlatArmorPenetrationMod")]
        public int RFlatArmorPenetrationMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat armor penetration modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat armor penetration modifier per level.
        /// </value>
        [JsonProperty("rFlatArmorPenetrationModPerLevel")]
        public int RFlatArmorPenetrationModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat crit chance modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat crit chance modifier per level.
        /// </value>
        [JsonProperty("rFlatCritChanceModPerLevel")]
        public int RFlatCritChanceModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat crit damage modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat crit damage modifier per level.
        /// </value>
        [JsonProperty("rFlatCritDamageModPerLevel")]
        public int RFlatCritDamageModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat dodge modifier.
        /// </summary>
        /// <value>
        ///     The rune flat dodge modifier.
        /// </value>
        [JsonProperty("rFlatDodgeMod")]
        public int RFlatDodgeMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat dodge modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat dodge modifier per level.
        /// </value>
        [JsonProperty("rFlatDodgeModPerLevel")]
        public int RFlatDodgeModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat energy modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat energy modifier per level.
        /// </value>
        [JsonProperty("rFlatEnergyModPerLevel")]
        public int RFlatEnergyModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat energy regneration modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat energy regneration modifier per level.
        /// </value>
        [JsonProperty("rFlatEnergyRegenModPerLevel")]
        public int RFlatEnergyRegenModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat gold per 10 modifier.
        /// </summary>
        /// <value>
        ///     The rune flat gold per 10 modifier.
        /// </value>
        [JsonProperty("rFlatGoldPer10Mod")]
        public int RFlatGoldPer10Mod { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat health point modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat health point modifier per level.
        /// </value>
        [JsonProperty("rFlatHPModPerLevel")]
        public int RFlatHpModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat health point regneration modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat health point regneration modifier per level.
        /// </value>
        [JsonProperty("rFlatHPRegenModPerLevel")]
        public int RFlatHpRegenModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat magic damage modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat magic damage modifier per level.
        /// </value>
        [JsonProperty("rFlatMagicDamageModPerLevel")]
        public int RFlatMagicDamageModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat magic penetration modifier.
        /// </summary>
        /// <value>
        ///     The rune flat magic penetration modifier.
        /// </value>
        [JsonProperty("rFlatMagicPenetrationMod")]
        public int RFlatMagicPenetrationMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat magic penetration modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat magic penetration modifier per level.
        /// </value>
        [JsonProperty("rFlatMagicPenetrationModPerLevel")]
        public int RFlatMagicPenetrationModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat movement speed modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat movement speed modifier per level.
        /// </value>
        [JsonProperty("rFlatMovementSpeedModPerLevel")]
        public int RFlatMovementSpeedModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat mana point modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat mana point modifier per level.
        /// </value>
        [JsonProperty("rFlatMPModPerLevel")]
        public int RFlatMpModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat mana point regneration modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat mana point regneration modifier per level.
        /// </value>
        [JsonProperty("rFlatMPRegenModPerLevel")]
        public int RFlatMpRegenModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat physical damage modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat physical damage modifier per level.
        /// </value>
        [JsonProperty("rFlatPhysicalDamageModPerLevel")]
        public int RFlatPhysicalDamageModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat spell block modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat spell block modifier per level.
        /// </value>
        [JsonProperty("rFlatSpellBlockModPerLevel")]
        public int RFlatSpellBlockModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat time dead modifier.
        /// </summary>
        /// <value>
        ///     The rune flat time dead modifier.
        /// </value>
        [JsonProperty("rFlatTimeDeadMod")]
        public int RFlatTimeDeadMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune flat time dead modifier per level.
        /// </summary>
        /// <value>
        ///     The rune flat time dead modifier per level.
        /// </value>
        [JsonProperty("rFlatTimeDeadModPerLevel")]
        public int RFlatTimeDeadModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent armor penetration modifier.
        /// </summary>
        /// <value>
        ///     The rune percent armor penetration modifier.
        /// </value>
        [JsonProperty("rPercentArmorPenetrationMod")]
        public int RPercentArmorPenetrationMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent armor penetration modifier per level.
        /// </summary>
        /// <value>
        ///     The rune percent armor penetration modifier per level.
        /// </value>
        [JsonProperty("rPercentArmorPenetrationModPerLevel")]
        public int RPercentArmorPenetrationModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent attack speed modifier per level.
        /// </summary>
        /// <value>
        ///     The rune percent attack speed modifier per level.
        /// </value>
        [JsonProperty("rPercentAttackSpeedModPerLevel")]
        public int RPercentAttackSpeedModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent cooldown modifier.
        /// </summary>
        /// <value>
        ///     The rune percent cooldown modifier.
        /// </value>
        [JsonProperty("rPercentCooldownMod")]
        public int RPercentCooldownMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent cooldown modifier per level.
        /// </summary>
        /// <value>
        ///     The rune percent cooldown modifier per level.
        /// </value>
        [JsonProperty("rPercentCooldownModPerLevel")]
        public int RPercentCooldownModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent magic penetration modifier.
        /// </summary>
        /// <value>
        ///     The rune percent magic penetration modifier.
        /// </value>
        [JsonProperty("rPercentMagicPenetrationMod")]
        public int RPercentMagicPenetrationMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent magic penetration modifier per level.
        /// </summary>
        /// <value>
        ///     The rune percent magic penetration modifier per level.
        /// </value>
        [JsonProperty("rPercentMagicPenetrationModPerLevel")]
        public int RPercentMagicPenetrationModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent movement speed modifier per level.
        /// </summary>
        /// <value>
        ///     The rune percent movement speed modifier per level.
        /// </value>
        [JsonProperty("rPercentMovementSpeedModPerLevel")]
        public int RPercentMovementSpeedModPerLevel { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent time dead modifier.
        /// </summary>
        /// <value>
        ///     The rune percent time dead modifier.
        /// </value>
        [JsonProperty("rPercentTimeDeadMod")]
        public int RPercentTimeDeadMod { get; set; }

        /// <summary>
        ///     Gets or sets the rune percent time dead modifier per level.
        /// </summary>
        /// <value>
        ///     The rune percent time dead modifier per level.
        /// </value>
        [JsonProperty("rPercentTimeDeadModPerLevel")]
        public int RPercentTimeDeadModPerLevel { get; set; }

        #endregion
    }

    public class ItemDatabaseEntry
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the colloq.
        /// </summary>
        /// <value>
        ///     The colloq.
        /// </value>
        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        /// <summary>
        ///     Gets or sets the amount of complete items needed to build this item.
        /// </summary>
        /// <value>
        ///     The amount of complete items needed to build this item.
        /// </value>
        [JsonProperty("depth")]
        public int? Depth { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the group.
        /// </summary>
        /// <value>
        ///     The group.
        /// </value>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        ///     Gets or sets the image.
        /// </summary>
        /// <value>
        ///     The image.
        /// </value>
        [JsonProperty("image")]
        public Image Image { get; set; }

        /// <summary>
        ///     Gets or sets the items this item builds into.
        /// </summary>
        /// <value>
        ///     The items this item builds into.
        /// </value>
        [JsonProperty("into")]
        public IList<string> Into { get; set; }

        /// <summary>
        ///     Gets or sets the item gold.
        /// </summary>
        /// <value>
        ///     The item gold.
        /// </value>
        [JsonProperty("gold")]
        public ItemGold ItemGold { get; set; }

        /// <summary>
        ///     Gets or sets the item stats.
        /// </summary>
        /// <value>
        ///     The item stats.
        /// </value>
        [JsonProperty("stats")]
        public ItemStats ItemStats { get; set; }

        /// <summary>
        ///     Gets or sets the maps this item is enabled on.
        /// </summary>
        /// <value>
        ///     The maps this item is enabled on.
        /// </value>
        [JsonProperty("maps")]
        public Dictionary<GameMapId, bool> Maps { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the plaintext.
        /// </summary>
        /// <value>
        ///     The plaintext.
        /// </value>
        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        /// <value>
        ///     The tags.
        /// </value>
        [JsonProperty("tags")]
        public IList<string> Tags { get; set; }

        #endregion
    }
}