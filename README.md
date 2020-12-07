# Web API For Maintaing Cloud Resources
## Purpose:
Create a library to create and maintain cloud infrastructure efficiently without needing to have deep knowledge about different cloud providers. This library will introduce APIs and abstractions that developers can use to design and implement cloud agnostic infrastructure.
## Requirements:
* **Phase #1:**
    * Supporting only virtual machines and database servers (database servers should support both MySQL and SQL Server).
    * Scalability for more resources (i.e. load balancers, elastic file storage etc.) at later stages.
    * To be able to create both Windows and Linux instances.
    * Create multiple infrastructures, for example create a UAT infrastructure for one project and a Test infrastructure for their internal team.
* The library should be .NET standard
* It should support creating and deleting infrastructures
* The library should have the implementation for a provider called IGS Cloud Services 
  > Note: IGS is an imaginary cloud provider in this assessment) 
  
  as the initial infrastructure provider but with an option to introduce new providers
* Output:
    * The output of creating an infrastructure should be a sub-directory in the provider directory with the same name as the infrastructure
    * A sub-directory for each resource type
    * For each resource there is a file containing the attributes of that resource should be created in the [infrastructure/resource type] directory.
	Example: IGS => UAT => VirtualMachine => UAT_SERVER.json => content: {property}
    * The delete API should accept the name of an infrastructure and delete all the associated resources
         * The implementation of deleting a resource is to delete the resource file on disk example delete UAT_SERVER.json
         * > **Important:** Do not delete the infrastructure folder. Dependency hierarchy should be followed, i.e. a virtual machine first should be deleted before deleting its hard disks.

