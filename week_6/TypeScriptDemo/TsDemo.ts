// take two objects that have string arrays
import { I1, MyClass1 } from "./TsDemoInterface1";
import { I2 } from "./TsDemoInterface2";

// alternately print out their strings
function AlternatingStrings(obj1: I1, obj2: I2) : string {
  // find the smaller arrays
  let smallerArray: number = Math.min(obj1.stringArray.length, obj2.stringArray1.length);
  let fullString: string = '';
  for (let i: number = 0; i < smallerArray; i++) {
    fullString += `${obj1.stringArray[i]} ${obj2.stringArray1[i]}`;
  }
  return fullString;
}

let myObj1: I1 = { stringArray: ["This", "a", "cool", "demo"], bigNumber: 12345675544335555890n, currentDate: new Date() };
let myObj2: I2 = { stringArray1: ["is", "really", "TypeScript", "."], integer: 100, isTrueOrFalse: true };

let resultString: string = AlternatingStrings(myObj1, myObj2);

console.log(resultString);