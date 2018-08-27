<?php

namespace MyBlogBundle\Controller;

use MyBlogBundle\Entity\Article;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;

class HomeController extends Controller
{
    /**
     * @Route("/", name="blog_index")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function index()
    {
        $articles = $this->getDoctrine()->getRepository(Article::class)->findAll();

        return $this->render('home/index.html.twig',
            [
                "articles" => $articles
            ]);
    }
}
