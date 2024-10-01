
# react-native-dancer-show-center

## Getting started

`$ npm install react-native-dancer-show-center --save`

### Mostly automatic installation

`$ react-native link react-native-dancer-show-center`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-dancer-show-center` and add `RNDancerShowCenter.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDancerShowCenter.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDancerShowCenterPackage;` to the imports at the top of the file
  - Add `new RNDancerShowCenterPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-dancer-show-center'
  	project(':react-native-dancer-show-center').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-dancer-show-center/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-dancer-show-center')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDancerShowCenter.sln` in `node_modules/react-native-dancer-show-center/windows/RNDancerShowCenter.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Dancer.Show.Center.RNDancerShowCenter;` to the usings at the top of the file
  - Add `new RNDancerShowCenterPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDancerShowCenter from 'react-native-dancer-show-center';

// TODO: What to do with the module?
RNDancerShowCenter;
```
  