﻿using AmeisenBotX.Core.Character.Inventory.Objects;
using AmeisenBotX.Core.Data.Enums;
using AmeisenBotX.Core.Data.Objects.WowObject;
using AmeisenBotX.Pathfinding.Objects;
using System;
using System.Collections.Generic;

namespace AmeisenBotX.Core.Hook
{
    public interface IHookManager
    {
        public bool IsWoWHooked { get; }

        void AcceptBattlegroundInvite();

        void AcceptPartyInvite();

        void AcceptResurrect();

        void AcceptSummon();

        void CastSpell(string name, bool castOnSelf = false);

        void CastSpellById(int spellId);

        void ClearTarget();

        void ClearTargetIfDead();

        void ClickOnTerrain(Vector3 position);

        void ClickToMove(IntPtr playerBase, Vector3 position);

        void CofirmBop();

        void CofirmReadyCheck(bool isReady);

        void DisposeHook();

        void EnableClickToMove();

        void FacePosition(WowPlayer player, Vector3 positionToFace);

        List<string> GetAuras(WowLuaUnit luaunit);

        List<string> GetBuffs(WowLuaUnit luaunit);

        List<string> GetDebuffs(WowLuaUnit luaunit);

        string GetEquipmentItems();

        int GetFreeBagSlotCount();

        string GetInventoryItems();

        string GetItemByNameOrLink(string itemName);

        string GetItemBySlot(int itemslot);

        string GetItemStats(string itemLink);

        string GetLocalizedText(string variable);

        string GetLootRollItemLink(int rollId);

        string GetMoney();

        Dictionary<RuneType, int> GetRunesReady(int runeId);

        List<string> GetSkills();

        double GetSpellCooldown(string spellName);

        string GetSpells();

        (string, int) GetUnitCastingInfo(WowLuaUnit luaunit);

        WowUnitReaction GetUnitReaction(WowUnit wowUnitA, WowUnit wowUnitB);

        bool HasUnitStealableBuffs(WowLuaUnit luaUnit);

        byte[] InjectAndExecute(string[] asm, bool readReturnBytes);

        bool IsBgInviteReady();

        bool IsClickToMovePending();

        bool IsCtmMoving(WowUnit unit);

        bool IsGhost(string unit);

        bool IsRuneReady(int runeId);

        bool IsSpellKnown(int spellId, bool isPetSpell = false);

        void KickNpcsOutOfMammoth();

        void LearnAllAvaiableSpells();

        void LeaveBattleground();

        void LootEveryThing();

        void LuaDoString(string command);

        void QueueBattlegroundByName(string bgName);

        void ReleaseSpirit();

        void RepairAllItems();

        void ReplaceItem(IWowItem currentItem, IWowItem newItem);

        void RetrieveCorpse();

        void RightClickObject(WowObject gObject);

        void RightClickUnit(WowUnit wowUnit);

        void RollOnItem(int rollId, RollType rollType);

        void SellAllGrayItems();

        void SellAllItems();

        void SellItemsByName(string itemName);

        void SendChatMessage(string message);

        void SendItemMailToCharacter(string itemName, string receiver);

        void SendMovementPacket(WowUnit unit, int opcode);

        void SetFacing(WowUnit unit, float angle);

        void SetMaxFps(byte maxFps);

        bool SetupEndsceneHook();

        void StartAutoAttack();

        void StopClickToMove(WowUnit unit);

        void TargetGuid(ulong guid);

        void TargetLuaUnit(WowLuaUnit unit);

        void TargetNearestEnemy();

        void UseItemByBagAndSlot(int bagId, int bagSlot);

        void UseItemByName(string itemName);
    }
}