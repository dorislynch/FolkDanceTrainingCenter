
# react-native-folk-dance-training-center

## Getting started

`$ npm install react-native-folk-dance-training-center --save`

### Mostly automatic installation

`$ react-native link react-native-folk-dance-training-center`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-folk-dance-training-center` and add `RNFolkDanceTrainingCenter.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNFolkDanceTrainingCenter.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNFolkDanceTrainingCenterPackage;` to the imports at the top of the file
  - Add `new RNFolkDanceTrainingCenterPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-folk-dance-training-center'
  	project(':react-native-folk-dance-training-center').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-folk-dance-training-center/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-folk-dance-training-center')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNFolkDanceTrainingCenter.sln` in `node_modules/react-native-folk-dance-training-center/windows/RNFolkDanceTrainingCenter.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Folk.Dance.Training.Center.RNFolkDanceTrainingCenter;` to the usings at the top of the file
  - Add `new RNFolkDanceTrainingCenterPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNFolkDanceTrainingCenter from 'react-native-folk-dance-training-center';

// TODO: What to do with the module?
RNFolkDanceTrainingCenter;
```
  