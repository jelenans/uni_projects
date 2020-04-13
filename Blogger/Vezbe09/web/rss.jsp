<?xml version="1.0" encoding="UTF-8"?>
<%@ page contentType="application/rss+xml; charset=ISO-8859-1" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<rss version="2.0"
          xmlns:content="http://purl.org/rss/1.0/modules/content/"
          xmlns:dc="http://purl.org/dc/elements/1.1/"
          xmlns:atom="http://www.w3.org/2005/Atom"
          xmlns:sy="http://purl.org/rss/1.0/modules/syndication/"
          xmlns:georss="http://www.georss.org/georss"
          xmlns:geo="http://www.w3.org/2003/01/geo/wgs84_pos#"
          xmlns:media="http://search.yahoo.com/mrss/">
    <channel>
	    <title>Blogger</title>
	    <link>${name}:${port}${path}</link>
	    <description>Blogging website</description>
	     
	    <c:forEach items="${posts}" var="post">
		    <item>
			    <title>${post.postTitle}</title>
			    <link>http://${name}:${port}${path}/ViewPostController?postId=${post.id}</link>
			    <description>${post.postSummary}</description>
		    </item>
	    </c:forEach>
    </channel>
</rss>
