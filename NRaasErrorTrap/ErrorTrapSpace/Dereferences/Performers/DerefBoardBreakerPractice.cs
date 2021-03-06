﻿using NRaas.CommonSpace.Booters;
using NRaas.CommonSpace.Helpers;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Interfaces;
using Sims3.Gameplay.Objects.HobbiesSkills;
using Sims3.Gameplay.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NRaas.ErrorTrapSpace.Dereferences
{
    public class DerefBoardBreakerPractice : Dereference<BoardBreaker.Practice>
    {
        protected override DereferenceResult Perform(BoardBreaker.Practice reference, FieldInfo field, List<ReferenceWrapper> objects)
        {
            ReferenceWrapper result;
            if (Matches(reference, "mTopBoardInStack", field, objects, out result) != MatchResult.Failure)
            {
                if (result.Valid)
                {
                    Remove(ref reference.mTopBoardInStack);
                }
                return DereferenceResult.ContinueIfReferenced;
            }

            return DereferenceResult.Failure;
        }
    }
}
