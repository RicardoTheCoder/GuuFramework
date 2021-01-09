﻿using System.Collections.Generic;

namespace Guu.API
{
    /// <summary>
    /// Serves as a handler for identifiables after being registered, mostly to sort them
    /// and identify them. Make a child of this class to create your own handlers
    /// </summary>
    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public class IdentifiableHandler
    {
        //+ CLASS LISTING
        internal static readonly HashSet<Identifiable.Id> MISC_CLASS = new HashSet<Identifiable.Id>(Identifiable.idComparer);
        internal static readonly HashSet<Identifiable.Id> ANIMAL_CLASS = new HashSet<Identifiable.Id>(Identifiable.idComparer);
        internal static readonly HashSet<Identifiable.Id> WATER_CLASS = new HashSet<Identifiable.Id>(Identifiable.idComparer);
        
        //+ PROPERTIES
        /// <summary>The owner of this handler</summary>
        public virtual GuuMod Owner { get; protected set; } = null;

        //+ HANDLING
        /// <summary>
        /// Sets up the handler
        /// </summary>
        /// <returns>Returns this handler for convenience</returns>
        public virtual IdentifiableHandler Setup()
        {
            ANIMAL_CLASS.UnionWith(Identifiable.MEAT_CLASS);
            ANIMAL_CLASS.UnionWith(Identifiable.CHICK_CLASS);

            WATER_CLASS.Add(Identifiable.Id.WATER_LIQUID);
            WATER_CLASS.Add(Identifiable.Id.MAGIC_WATER_LIQUID);
            
            return this;
        }
        
        /// <summary>
        /// Organizes the identifiable by adding it to its list
        /// </summary>
        /// <param name="id">The ID to organize</param>
        /// <param name="type">The type of identifiable</param>
        public virtual void Organize(Identifiable.Id id, IdentifiableType type)
        {
            IdentifiableRegistry.AddToType(id, type);
        }

        /// <summary>
        /// Handles the identifiables. This runs after everything is loaded, to allow you to
        /// manipulate identifiables if needed, to adjust values or make inter mod stuff
        /// </summary>
        public virtual void Handle() { }

        /// <summary>
        /// Clear any values from the handler that are no longer used to save up memory
        /// </summary>
        public virtual void ClearMemory() { }

        //+ VERIFICATION
        ///<summary>Checks if the ID is a veggie</summary>
        public static bool IsVeggie(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.VEGGIE);
        
        ///<summary>Checks if the ID is a slime</summary>
        public static bool IsSlime(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.SLIME);
        
        ///<summary>Checks if the ID is a gordo</summary>
        public static bool IsGordo(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.GORDO);
        
        ///<summary>Checks if the ID is a largo</summary>
        public static bool IsLargo(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.LARGO);
        
        ///<summary>Checks if the ID is a plort</summary>
        public static bool IsPlort(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.PLORT);
        
        ///<summary>Checks if the ID is a animal</summary>
        public static bool IsAnimal(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.ANIMAL);
        
        ///<summary>Checks if the ID is a chick</summary>
        public static bool IsChick(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.CHICK);
        
        ///<summary>Checks if the ID is a food</summary>
        public static bool IsFood(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.FOOD);
        
        ///<summary>Checks if the ID is a fruit</summary>
        public static bool IsFruit(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.FRUIT);
        
        ///<summary>Checks if the ID is a craft</summary>
        public static bool IsCraft(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.CRAFT);
        
        ///<summary>Checks if the ID is a echo</summary>
        public static bool IsEcho(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.ECHO);
        
        ///<summary>Checks if the ID is a echo note</summary>
        public static bool IsEchoNote(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.ECHO_NOTE);
        
        ///<summary>Checks if the ID is a ornament</summary>
        public static bool IsOrnament(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.ORNAMENT);
        
        ///<summary>Checks if the ID is a toy</summary>
        public static bool IsToy(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.TOY);
        
        ///<summary>Checks if the ID is a liquid</summary>
        public static bool IsLiquid(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.LIQUID);
        
        ///<summary>Checks if the ID is water</summary>
        public static bool IsWater(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.WATER);
        
        ///<summary>Checks if the ID is a fashion</summary>
        public static bool IsFashion(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.FASHION);
        
        ///<summary>Checks if the ID is a non slime resource</summary>
        public static bool IsNonSlimeResource(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.NON_SLIME);
        
        ///<summary>Checks if the ID is allergy free</summary>
        public static bool IsAllergyFree(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.ALLERGY_FREE);
        
        ///<summary>Checks if the ID is a tarr</summary>
        public static bool IsTarr(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.TARR);
        
        ///<summary>Checks if the ID is misc</summary>
        public static bool IsMisc(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.MISC);
        
        ///<summary>Checks if the ID is a scene object</summary>
        public static bool IsSceneObject(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.SCENE_OBJECT);
        
        ///<summary>Checks if the ID is boop</summary>
        public static bool IsBoop(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.BOOP);
        
        ///<summary>Checks if the ID is a elder</summary>
        public static bool IsElder(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.ELDER);
        
        ///<summary>Checks if the ID is a standard crate</summary>
        public static bool IsStandardCrate(Identifiable.Id id) => IdentifiableRegistry.IsTypeValid(id, IdentifiableType.STANDARD_CRATE);
    }
}