using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement
{
    class LoggedInAdministratorFacade : AnonymousUserFacade, ILoggedInAdministratorFacade, IFacade
    {
        /// <summary>
        /// Create new administrator by using given administrator.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="administrator"></param>
        /// <returns></returns>
        public long CreateNewAdministrator(LoginToken<Administrator> token, Administrator administrator)
        {
            if (token != null)
            {
                return _administrator.Add(administrator);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        ///  Create new Country by using given Country.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public long CreateNewCountry(LoginToken<Administrator> token, Country country)
        {
            if (token != null)
            {
               return _countryDAO.Add(country);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Create new airline company by using given airline company.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="airline"></param>
        public long CreateNewAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {
            if (token != null)
            {
                return _airlineDAO.Add(airline);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Create new Customer by using given customer.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customer"></param>
        public long CreateNewCustomer(LoginToken<Administrator> token, Customer customer)
        {
            if (token != null)
            {
                return _customerDAO.Add(customer);
            }
            else
                throw new Exception("Token can't be null");
        }
        public long CreateFlight(LoginToken<Administrator> token, Flight flight)
        {
            if (token != null)
            {
                return _flightDAO.Add(flight);
            }
            else
                throw new Exception("Token can't be null");

        }
        /// <summary>
        /// Remove Country By country ID
        /// </summary>
        /// <param name="token"></param>
        /// <param name="country"></param>
        public void RemoveCountry(LoginToken<Administrator> token, Country country)
        {
            if (token != null)
            {
                _ticketDAO.RemoveTicketsByCountryCode(country.ID);
                _flightDAO.RemoveFlightsByCountryCode(country.ID);
                _airlineDAO.RemoveAirlineCompanyByCountryCode(country.ID);
                _countryDAO.Remove(country);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Remove airline company by using given airline company.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="airline"></param>
        public void RemoveAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {
            if (token != null)
            {
                _ticketDAO.RemoveTicketsByAirlineCompanyId(airline.ID);
                _flightDAO.RemoveFlightsByAirlineCompanyId(airline.ID);
                _airlineDAO.Remove(airline);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Remove customer by using given customer.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customer"></param>
        public void RemoveCustomer(LoginToken<Administrator> token, Customer customer)
        {
            if (token != null)
            {
                _ticketDAO.RemoveTicketsByCustomerId(customer.ID);
                _customerDAO.Remove(customer);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Update airline company details by using given airline data.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customer"></param>
        public void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompany airline)
        {
            if (token != null)
            {
                _airlineDAO.Update(airline);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Update customer details by using given customer data.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customer"></param>
        public void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer)
        {
            if (token != null)
            {
                _customerDAO.Update(customer);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get Customer By customer ID
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer GetCustomerById(LoginToken<Administrator> token, long customerId)
        {
            if (token != null)
            {
                return _customerDAO.Get(customerId);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get Airline Company By airline company ID
        /// </summary>
        /// <param name="token"></param>
        /// <param name="airlineCompanyId"></param>
        /// <returns></returns>
        public AirlineCompany GetAirlineCompanyById(LoginToken<Administrator> token, long airlineCompanyId)
        {
            if (token != null)
            {
                return _airlineDAO.Get(airlineCompanyId);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get country By country code
        /// </summary>
        /// <param name="token"></param>
        /// <param name="CountryCode"></param>
        /// <returns></returns>
        public Country GetCountryByCode(LoginToken<Administrator> token, long CountryCode)
        {
            if (token != null)
            {
                return _countryDAO.Get(CountryCode);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get all customers
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public IList<Customer> GetAllCustomers(LoginToken<Administrator> token)
        {
            if (token != null)
            {
                return _customerDAO.GetAll();
            }
            else
                throw new Exception("Token can't be null");
        }
        public IList<Country> GetAllCountries(LoginToken<Administrator> token)
        {
            if (token != null)
            {
                return _countryDAO.GetAll();
            }
            else
                throw new Exception("Token can't be null");
        }
        public IList<AirlineCompany> GetAllAirlineCompanies(LoginToken<Administrator> token)
        {
            if (token != null)
            {
                return _airlineDAO.GetAll();
            }
            else
                throw new Exception("Token can't be null");
        }
        public IList<Flight> GetAllFlights(LoginToken<Administrator> token)
        {
            if (token != null)
            {
                return _flightDAO.GetAll();
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get customer by user name
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Customer GetCustomerByUserName(LoginToken<Administrator> token, string userName)
        {
            if (token != null)
            {
                return _customerDAO.GetCustomerByUsername(userName);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get country by country name
        /// </summary>
        /// <param name="token"></param>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public Country GetCountryByName(LoginToken<Administrator> token, string countryName)
        {
            if (token != null)
            {
                return _countryDAO.GetCountryByName(countryName);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get airline company by airline company name
        /// </summary>
        /// <param name="token"></param>
        /// <param name="AirlineName"></param>
        /// <returns></returns>
        public AirlineCompany GetAirlineCompanyByAirlineName(LoginToken<Administrator> token, string AirlineName)
        {
            if (token != null)
            {
                return _airlineDAO.GetAirlineCompanyByAirlineName(AirlineName);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get administrator by administrator user name.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="administratorUserName"></param>
        /// <returns></returns>
        public Administrator GetAdministratorByUserName(LoginToken<Administrator> token, string administratorUserName)
        {
            if (token != null)
            {
                return _administrator.GetAdministratorByUserName(administratorUserName);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Get administrator by administrator id.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Ticket GetTicketByCustomerId(LoginToken<Administrator> token, long customerId)
        {
            if (token != null)
            {
                return _ticketDAO.GetTicketByCustomerId(customerId);
            }
            else
                throw new Exception("Token can't be null");
        }
        /// <summary>
        /// Add ticket by using customer id and flight id.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customerId"></param>
        /// <param name="flightId"></param>
        public void AddTicket(LoginToken<Administrator> token, long customerId, long flightId)
        {
            if (token != null)
            {
                Ticket ticket = new Ticket()
                {
                    FLIGHT_ID = flightId,
                    CUSTOMER_ID = customerId
                };
                long ID = _ticketDAO.Add(ticket);
                ticket.ID = ID;
                _flightDAO.UpdateRemainingTickets(flightId);
            }
            else
                throw new Exception("Token can't be null");
        }
    }
}
