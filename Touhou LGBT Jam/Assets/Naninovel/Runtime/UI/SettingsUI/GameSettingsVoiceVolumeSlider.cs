﻿// Copyright 2017-2020 Elringus (Artyom Sovetnikov). All Rights Reserved.


namespace Naninovel.UI
{
    public class GameSettingsVoiceVolumeSlider : ScriptableSlider
    {
        private IAudioManager audioMngr;

        protected override void Awake ()
        {
            base.Awake();

            audioMngr = Engine.GetService<IAudioManager>();
        }

        protected override void Start ()
        {
            base.Start();

            UIComponent.value = audioMngr.SfxVolume;
        }

        protected override void OnValueChanged (float value)
        {
            audioMngr.VoiceVolume = value;
        }
    }
}
