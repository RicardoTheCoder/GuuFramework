﻿using Guu.Utils;
using UnityEngine;

namespace Guu.API.SpawnResources
{
	/// <summary>
	/// This is the base class to make garden spawn resources (patches)
	/// </summary>
	public abstract class PatchGardenResource : SpawnResourceItem
	{
		/// <summary>The name prefix for this object</summary>
		protected override string NamePrefix => "patch";

		/// <summary>Is this a garden resource?</summary>
		protected sealed override bool IsGarden => true;

		/// <summary>The base item to use when creating the one</summary>
		protected virtual GameObject BaseItem => IsDeluxe ?
			GameContext.Instance.LookupDirector?.GetResourcePrefab(SpawnResource.Id.CARROT_PATCH_DLX) ?? SRObjects.Get<GameObject>("patchCarrot04") :
			GameContext.Instance.LookupDirector?.GetResourcePrefab(SpawnResource.Id.CARROT_PATCH) ?? SRObjects.Get<GameObject>("patchCarrot01");

		/// <summary>Builds this Item</summary>
		protected override void Build()
		{
			// Get GameObjects
			Prefab = PrefabUtils.BuildPrefab(NamePrefix + Name, BaseItem);

			// Load Components
			SpawnResource spawn = Prefab.GetComponent<SpawnResource>();

			// Setup Components
			spawn.id = ID;
			spawn.ObjectsToSpawn = GameContext.Instance.LookupDirector.GetPrefabs(ToSpawn);
			spawn.BonusObjectsToSpawn = BonusToSpawn != null ? GameContext.Instance.LookupDirector.GetPrefabs(BonusToSpawn) : new GameObject[0];
			spawn.MaxObjectsSpawned = MaxObjectsSpawned;
			spawn.MinObjectsSpawned = MinObjectsSpawned;
			spawn.MinNutrientObjectsSpawned = MinNutrientObjectsSpawned == -1 ? MaxObjectsSpawned : MinNutrientObjectsSpawned;
			spawn.MinSpawnIntervalGameHours = MinSpawnIntervalGameHours;
			spawn.MaxSpawnIntervalGameHours = MaxSpawnIntervalGameHours;
			spawn.BonusChance = BonusChance;
			spawn.minBonusSelections = MinBonusSelections;

			// Builds the Spawn Points
			BuildSpawnPoints(spawn);
		}
	}
}
