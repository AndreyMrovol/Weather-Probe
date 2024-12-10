namespace WeatherProbe{

	internal class WeatherRegistryPatches{

		public static bool IsModPresent => BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("mrov.WeatherRegistry");

		public static void SetWeatherOnHost(SelectableLevel level, LevelWeatherType weatherType){
			if(IsModPresent){
				WeatherRegistry.WeatherController.ChangeWeather(level, weatherType);
			}
		}
	}

}