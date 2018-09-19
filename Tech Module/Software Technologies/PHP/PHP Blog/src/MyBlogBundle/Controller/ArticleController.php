<?php

namespace MyBlogBundle\Controller;


use MyBlogBundle\Entity\Article;
use MyBlogBundle\Form\ArticleType;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class ArticleController extends Controller
{
    /**
     * @Route("/article/create", name="article_create")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function createArticle(Request $request)
    {
        $article = new Article();
        $form = $this->createForm(ArticleType::class, $article);
        $form->handleRequest($request);
        if ($form->isSubmitted() && $form->isValid()) {
            $user = $this->getUser();
            $article->setAuthor($user);

            $em = $this->getDoctrine()->getManager();
            $em->persist($article);
            $em->flush();

            return $this->redirectToRoute('blog_index');
        }

        return $this->render('article/create.html.twig',
            [
                "form" => $form->createView()
            ]);
    }

    /**
     * @Route("/article/details/{id}", name="article_details")
     * @param $id
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function details($id)
    {
        $repository = $this->getDoctrine()->getRepository(Article::class);
        $article = $repository->find($id);

        return $this->render('article/details.html.twig', [
            "article" => $article
        ]);
    }


    /**
     * @Route("/article/edit/{id}", name="article_edit")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function editArticle($id, Request $request)
    {
        $repository = $this
            ->getDoctrine()
            ->getRepository(Article::class);
        $article = $repository->find($id);

        $form = $this->createForm(ArticleType::class, $article);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            $em = $this->getDoctrine()->getManager();
            $em->merge($article);
            $em->flush();

            return $this->redirectToRoute('user_articles');
        }

        return $this->render('article/edit.html.twig',
            [
                'article' => $article,
                'form' => $form->createView()
            ]);
    }

    /**
     * @Route("/article/delete/{id}", name="article_delete")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function deleteArticle($id, Request $request)
    {
        $repository = $this
            ->getDoctrine()
            ->getRepository(Article::class);
        $article = $repository->find($id);

        $form = $this->createForm(ArticleType::class, $article);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            $em = $this->getDoctrine()->getManager();
            $em->remove($article);
            $em->flush();

            return $this->redirectToRoute('user_articles');
        }

        return $this->render('article/delete.html.twig',
            [
                'article' => $article,
                'form' => $form->createView()
            ]);
    }
}
