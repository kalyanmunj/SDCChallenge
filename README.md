# SDCChallenge

# Code Challenge
Speaking of smiles, if you are interested in space flight then this challenge will probably make you smile. We would love to see you demonstrate
your technical prowess using your knowledge of OOD best practices and your ability to apply sound software design concepts utilizing the C#
language with the ASP.NET Core framework. We would like you to build a basic RESTful service which exposes SpaceX launch pad
information. The SpaceX launchpad information is backed by the free r/SpaceX API provided here: https://github.com/r-spacex/SpaceX-API/wiki/
Launchpad-Info. The caveat to this challenge is to design the solution with the knowledge that the SpaceX API will later be replaced by an
internal database to house the launchpad information. The expectation is to be able to change the data source with minimal impact to the service
API code and/or any other project libraries you develop to support the solution.
# Guidelines
We aren’t looking for a production ready solution, but would like you to show your knowledge, skill, and creativity in building the solution.
You can start with the basic template for an ASP.NET Core Web API solution and use that to build the service application to expose the
SpaceX launchpad information.
The object model to expose via the ASP.NET Web API solution should have the following attributes only:
Launchpad Id (maps to the “id” field from the SpaceX API)
Launchpad Name (maps to the “full_name” field from the SpaceX API)
Launchpad Status (maps to the “status” field from the SpaceX API)
Utilize the public API for SpaceX launchpad information: https://api.spacexdata.com/v2/launchpads.
Include some level of unit testing.
Ensure there is some sort of logging.
Ensure the application is configured via external configuration where it makes sense.
Design the solution in such a way that that a database can later be used to replace the SpaceX REST API which incurs as little
re-work/re-factor as possible.
Make design decisions with the consideration that the service will be cloud hosted, need to be horizontally scalable, and will be potentially
hosted within a microservice or SOA ecosystem.
BONUS POINTS: You can definitely make us smile if you put some thought and time into adding the functionality for consuming clients of
the ASP.NET Core API endpoint(s) to apply filters in order to constrain the launchpad result set. You can reference the SpaceX API
documentation here for potential guidance: https://github.com/r-spacex/SpaceX-API/wiki/Launchpad-Info
