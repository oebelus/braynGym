import './App.css';
import { Component } from 'react';

//Components
import A from './Components/A';
import R from './Components/R';
import Sharingan from './Components/Sharingan';
import Square from './Components/Square';

function copyR() {
    var copyText = `
    <div class='letter'>R</div>
    <style>
      body {
        background-color: #EFF2F1
      }
    
      .letter {
        font-size: 271px;
        translate: 100px -15px;
        font-weight: bold;
        color: #1C1C1C;
        border-radius: 10px
      }
    </style>`

    navigator.clipboard.writeText(copyText);

    alert("Copied!");
}

function copySharingan() {
  var copyText = `
  <div class='outer-circle'></div>
  <div class='inner-circle'></div>
  <div class='middle-circle'></div>
  
  <style>

    body {
      background: #161616
    }
    .outer-circle {
      background: #A22015;
      position: absolute; 
      width: 190px;
      height: 190px;
      background: #A22015;
      border-radius: 50%; 
      left: 50%;
      top: 50%;
      translate: -50% -50%;
      border: 6px solid #000000;
    }
  
    .inner-circle {
      position: absolute;
      background: #000000; 
      width: 50px;
      height: 50px;
      border-radius: 50%; 
      border: 10px solid #E96A23;
      left: 50%;
      top: 50%;
      translate: -50% -50%
    }
  
    .middle-circle {
      position: absolute; 
      border: 15px solid #000000; 
      left: 50%;
      top: 50%;
      translate: -50% -50%;
      width: 70px;
      height: 70px;
      border-radius: 50%;
    }

  </style>`

  navigator.clipboard.writeText(copyText);

  alert("Copied!");
}

function copySquare() {
  var copyText= `
  <div class='rec-1'></div>
  <div class='rec-2'></div>
  <div class='square'></div>
  <style>
    body {
      background: #F3AC3C
    }
    .rec-1 {
      position: absolute; 
      width: 148px;
      height: 100px;
      background: #1A4341;
      translate: 60px 57px;
      border-radius: 10px
    }
    .rec-2 {
      position: absolute; 
      width: 148px;
      height: 100px;
      background: #1A4341;
      translate: 180px 127px;
      border-radius: 10px
    }
    .square {
      position: absolute; 
      width: 70px;
      height: 70px;
      background: #F3AC3C; 
      left: 50%;
      top: 50%; 
      translate: -50% -50%; 
      border-radius: 10px
    }
  </style>
  `
  navigator.clipboard.writeText(copyText);

  alert("Copied!");
}

function copyA() {
    var copyText = `
    <div class='line-2'></div>
<div class='line-1'></div>
<div class='line-3'></div>
<div class='line-4'></div>
<style>
  body {
    background-color: #62306D; 
  }
  .line-1 {
    width: 40px;
    height: 140px;
    background: #dd6b4d;
    background-color: #FEF9CA;
    translate: 142px 72px;
    transform: skew(-21deg);
    z-index: 5; 
    position: absolute;
  }
  .line-2 {
    width: 45px;
    height: 140px;
    background-color: #C5B732;
    transform: skew(20deg);
    translate: 204px 72px;
    z-index: -1;
    position: absolute;
  }

  .line-3 {
    width: 54px;
    height: 50px;
    background-color: #AA445F;
    transform: skew(40deg);
    translate: 190px 162px;
    z-index: -1;
    position: absolute;
  }

  .line-4 {
    width: 54px;
    height: 50px;
    background-color: #E38F66;
    transform: skew(-40deg);
    translate: 140px 162px;
    z-index: 5;
    position: absolute;
  }
</style>`

    navigator.clipboard.writeText(copyText);

    alert("Copied!");
}

class App extends Component {
    render() {
        return(
            <div className='grid-container'>
                <div onClick={() => {copyA()}} className="grid item-1 btn"><A/></div>
                <div onClick={copyR} className="grid item-2"><R/></div>
                <div onClick={copySharingan} className='grid item-3'><Sharingan/></div>
                <div onClick={copySquare} className='grid item-4'><Square/></div>
            </div>
        )
    }
}

export default App;

