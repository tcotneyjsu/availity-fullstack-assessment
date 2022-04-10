import React from 'react';
import './App.css';

class RequestForm extends React.Component {
    constructor(props) {
        super(props);
        this.state = { firstName: '', lastName: '', npiNumber: '', businessAddress: '', telephoneNumber: '', emailAddress: ''};

        this.handleFNChange = this.handleFNChange.bind(this);
        this.handleLNChange = this.handleLNChange.bind(this);
        this.handleNPINumberChange = this.handleNPINumberChange.bind(this);
        this.handleBusinessAddressChange = this.handleBusinessAddressChange.bind(this);
        this.handleTelephoneNumberChange = this.handleTelephoneNumberChange.bind(this);
        this.handleEmailChange = this.handleEmailChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleFNChange(event) {
        this.setState({ firstName: event.target.value});
    }
    handleLNChange(event) {
        this.setState({ lastName: event.target.value });
    }
    handleNPINumberChange(event) {
        this.setState({ npiNumber: event.target.value });
    }
    handleBusinessAddressChange(event) {
        this.setState({ businessAddress: event.target.value });
    }
    handleTelephoneNumberChange(event) {
        this.setState({ telephoneNumber: event.target.value });
    }
    handleEmailChange(event) {
        this.setState({ emailAddress: event.target.value });
    }

    handleSubmit(event) {
        const { firstName, lastName, npiNumber, businessAddress, telephoneNumber, emailAddress } = this.state;
        event.preventDefault();
        alert('A request was made with the following details: \nFirst name: ' + firstName + '\nLast Name: ' + lastName +
            '\nNPI Number: ' + npiNumber + '\nBusiness Address: ' + businessAddress + '\nTelephone Number: ' + telephoneNumber +
            '\nEmail Address: ' + emailAddress);
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <div class="inputs">
                    <label>
                        First Name:
                        <input type="text" value={this.state.firstName} onChange={this.handleFNChange} />
                    </label>
                </div>
                <div class="inputs">
                    <label>
                        Last Name:
                        <input type="text" value={this.state.lastName} onChange={this.handleLNChange} />
                    </label>
                </div>
                <div class="inputs">
                    <label>
                        NPI Number:
                        <input type="text" value={this.state.npiNumber} onChange={this.handleNPINumberChange} />
                    </label>
                </div>
                <div class="inputs">
                    <label>
                        Business Address:
                        <input type="text" value={this.state.businessAddress} onChange={this.handleBusinessAddressChange} />
                    </label>
                </div>
                <div class="inputs">
                    <label>
                        Telephone Number:
                        <input type="text" value={this.state.telephoneNumber} onChange={this.handleTelephoneNumberChange} />
                    </label>
                </div>
                <div class="inputs">
                    <label>
                        Email Address:
                        <input type="text" value={this.state.emailAddress} onChange={this.handleEmailChange} />
                    </label>
                </div>
                <div class="inputs">
                    <input type="submit" value="Submit" />
                </div>
            </form>
        );
    }
}

export default RequestForm;