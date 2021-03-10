# PrintNavigationItems

Problem:

We have a class that models navigation items for our client websites. 
There is a root level item which is not displayed, but contains a list of child items.
These child items may have child items, which may also have child items, to an arbitrary level of depth. 
Write a method in C# or Java that takes in the root level NavigationItem and prints out the navigation 
structure in a format that a non-developer could understand and use to help them troubleshoot issues with a site. 
 
You can assume that all Lists of children are non-null and have length of zero when they are empty.
 
 
public class NavigationItem 
{
	public string Url; 
	public string Label; 
	public List<NavigationItem> Children; 
}

Output:

- Level1
  - Level1-Sub1
- Level2
  - Level2-Sub1
  - Level2-Sub2
- Level3
  - Level3-Sub1
