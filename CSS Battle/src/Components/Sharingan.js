import './css/Sharingan.css'
import { Component } from 'react'

class Sharingan extends Component {
    render() {
        return(
            <div className="sharingan">
                <div className='outer-circle'></div>
                <div className='inner-circle'></div>
                <div className='middle-circle'></div>
            </div>
        )
    }
}

export default Sharingan