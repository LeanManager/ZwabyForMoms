# ZwabyForMoms
We enable homeowners to book cleaning services on-demand!

Main priorities so we can release fast to the Apple and Google Play stores (not including UI):

1) When user registers for the first time, next time they open the app they are immediately taken to the main screen. Update ‘Profile’ screen with those entry.Text fields from the ‘RegistrationForm’ screen.

2) When user completes registration successfully, aggregate information into a string and send email with that information to zwabyapp@gmail.com

3) When user completes a booking, aggregate certain information from every screen into a string and send email with that information to zwabyapp@gmail.com. Update ‘Current Booking’ screen with those key fields.

4) Ability to charge credit cards “manually”. Money goes to Zwaby’s bank account.


These are the secondary things we need to add to the current Xamarin.Forms app:

1) One-time password (OTP) verification API in the registration form screen.
2) Azure SQL database to store user registrations.
3) Azure push notifications to alert users strategically.
4) Email notification API to alert us when users book a cleaning service.
5) Stripe API to accept electronic payment from users.
