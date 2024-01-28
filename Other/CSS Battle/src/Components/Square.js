import './css/Square.css'

import { Component } from 'react'

class Square extends Component {
    render() {
        return(
            <div className="squares">
                <div class='rec-1'></div>
                <div class='rec-2'></div>
                <div class='square'></div>
            </div>
        )
    }
}

export default Square