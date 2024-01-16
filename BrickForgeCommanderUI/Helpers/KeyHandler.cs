using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Helpers
{
    public class KeyHandler
    {
        private readonly Dictionary<Keys, Action> singleKeyActions;
        private readonly Dictionary<Keys, Action> combinationKeyActions;

        public KeyHandler()
        {
            singleKeyActions = new Dictionary<Keys, Action>();
            combinationKeyActions = new Dictionary<Keys, Action>();
        }

        public void AddKeyAction(Keys key, Action action)
        {
            if (!singleKeyActions.ContainsKey(key))
            {
                singleKeyActions[key] = action;
            }
            else
            {
                singleKeyActions[key] += action;
            }
        }

        public void AddKeyAction(List<Keys> keys, Action action)
        {
            var combination = keys.Aggregate(Keys.None, (current, key) => current | key);

            if (!combinationKeyActions.ContainsKey(combination))
            {
                combinationKeyActions[combination] = action;
            }
            else
            {
                combinationKeyActions[combination] += action;
            }
        }

        public void HandleKeyPress(Keys key, Keys modifierKeys)
        {
            if (modifierKeys == Keys.None)
            {
                if (singleKeyActions.ContainsKey(key))
                {
                    singleKeyActions[key]?.Invoke();
                }
            }
            else
            {
                var combination = modifierKeys | key;
                if (combinationKeyActions.ContainsKey(combination))
                {
                    combinationKeyActions[combination]?.Invoke();
                }
            }
        }
    }
}